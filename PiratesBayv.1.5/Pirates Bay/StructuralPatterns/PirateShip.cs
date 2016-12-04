using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirates_Bay.CreationalPatterns;

namespace Pirates_Bay.StructuralPatterns
{
    class PirateShip: Ship
    {
        public double ProbabilityOfSeizure { get; set; }

        public PirateShip(double probabilityOfSeizure, int health, int speed, int damage, Point position)
            : base(health, speed, damage, position)
        {
            if (probabilityOfSeizure >= 0 && probabilityOfSeizure < 1)
                ProbabilityOfSeizure = probabilityOfSeizure;
            else
            {
                throw new ArgumentOutOfRangeException("probabilityOfSeizure", "Argument must has value between 0 and 1");
            }
        }

        public override void Attack(Ship enemy)
        {
            base.Attack(enemy);

            //SoundsGenerator.Instance.PlayPirateShipCannonShot();
            //SoundsGenerator.Instance.PlayPiratesScream();
        }
    }
}
