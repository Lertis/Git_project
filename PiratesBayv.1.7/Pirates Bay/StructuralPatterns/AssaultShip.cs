using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirates_Bay.CreationalPatterns;

namespace Pirates_Bay.StructuralPatterns
{
    class AssaultShip:Ship
    {
        private int _numberOfValleys;

        public AssaultShip(int health, int speed, int damage, int numberOfValleys, Point position)
            : base(health, speed, damage, position)
        {
            this._numberOfValleys = numberOfValleys;
        }

        public override void Attack(Ship enemy)
        {
            for (int i = 0; i < _numberOfValleys; i++)
            {
                base.Attack(enemy);
                //SoundsGenerator.Instance.PlayAssaultShipCannonShot();
            }
        }
    }
}
