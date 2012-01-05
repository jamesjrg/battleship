using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship.Model
{
    class Player
    {
        const int GRID_SIZE = 10;
        static private int[] shipLengths = new int[] { 5, 4, 3, 3, 2 };

        static Random rnd = new Random();

        public List<List<SeaSquare>> MyGrid { get; set; }
        public List<List<SeaSquare>> EnemyGrid { get; set; }

        public Player()
        {
            MyGrid = new List<List<SeaSquare>>();
            EnemyGrid = new List<List<SeaSquare>>();

            for (int i = 0; i != GRID_SIZE; ++i)
            {
                MyGrid.Add(new List<SeaSquare>());
                EnemyGrid.Add(new List<SeaSquare>());

                for (int j = 0; j != GRID_SIZE; ++j)
                {
                    MyGrid[i].Add(new SeaSquare(i, j));
                    EnemyGrid[i].Add(new SeaSquare(i, j));
                }
            }

            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i != GRID_SIZE; ++i)
            {
                for (int j = 0; j != GRID_SIZE; ++j)
                {
                    MyGrid[i][j].Type = SquareType.Water;
                    EnemyGrid[i][j].Type = SquareType.Unknown;
                }
            }

            PlaceShips();
        }

        private void PlaceShips()
        {
            foreach (int length in shipLengths)
            {
                //xxx
                int startPosRow = rnd.Next(GRID_SIZE);
                int startPosCol = rnd.Next(GRID_SIZE);
                MyGrid[startPosRow][startPosCol].Type = SquareType.Undamaged;
            }
        }

        //check surrounding squares to see if ship has been sunk
        //could alternately keep track of ships as seperate data
        private bool IsSunk(int row, int col)
        {
            int i = Math.Max(0, row - 1);
            int j = Math.Max(0, col - 1);
            int iEnd = Math.Min (GRID_SIZE, row + 2);
            int jEnd = Math.Min (GRID_SIZE, col + 2);

            for (; i != iEnd; ++i)
            {
                for (; j != jEnd; ++j)
                    if ((i != row || j != col) && MyGrid[i][j].Type == SquareType.Undamaged)
                        return false;
            }

            return true;
        }

        public SquareType FiredAt(int row, int col)
        {
            switch (MyGrid[row][col].Type)
            {
                case SquareType.Water:
                    return SquareType.Water;
                case SquareType.Undamaged:                    
                    if (!IsSunk(row, col))
                        MyGrid[row][col].Type = SquareType.Damaged;
                    else
                        MyGrid[row][col].Type = SquareType.Sunk;
                    
                    return MyGrid[row][col].Type;
                case SquareType.Damaged:
                    goto default;
                case SquareType.Unknown:
                    goto default;
                case SquareType.Sunk:
                    goto default;
                default:
                    throw new Exception("fail");
            }
        }
    }
}
