using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirates_Bay.CreationalPatterns;

namespace Pirates_Bay.StructuralPatterns
{
    class CargoShip:Ship
    {
        public int CarryingCapacity { get; set; }
        public int Resources { get; set; }

        public CargoShip(int health, int speed, int damage, Point position, int capacity)
            : base(health, speed, damage, position)
        {
            CarryingCapacity = capacity;
            Resources = 0;
        }

        public override void Attack(Ship enemy)
        {
            base.Attack(enemy);

            //SoundsGenerator.Instance.PlayTradeShipCannonShot();

        }

        public void ColectResources(int amount)
        {
            Resources += amount;
        }
    }
}
