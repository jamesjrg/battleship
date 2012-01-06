using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship.Model
{
    enum ShipType {Carrier, Battleship, Destroyer, Submarine, PatrolBoat};

    class Ship
    {
        public int health;

        private readonly ShipType _type;
        
        private static readonly Dictionary<ShipType, int> shipLengths =
            new Dictionary<ShipType, int>()
        {
            {ShipType.Carrier, 5},
            {ShipType.Battleship, 4},
            {ShipType.Destroyer, 3},
            {ShipType.Submarine, 3},
            {ShipType.PatrolBoat, 2}
        };

        public Ship(ShipType type)
        {
            _type = type;
            Reincarnate();
        }

        public void Reincarnate()
        {
            health = shipLengths[_type];
        }

        public int Length
        {
            get
            {
                return shipLengths[_type];
            }
        }
        
        public bool IsSunk
        {
            get
            {
                return health == 0 ? true : false;
            }
        }

        public bool FiredAt()
        {
            health--;
            return IsSunk;
        }
    }
}
