using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirates_Bay.StructuralPatterns;

namespace Pirates_Bay.BehavioralPatterns
{
    public abstract class Mediator
    {
        public abstract void Attack(object sender);
    }

    public class ShipsMediator : Mediator
    {
        private Ship _firstShip;
        private Ship _secondShip;

        public Ship FirstShip { set { _firstShip = value; } }
        public Ship SecondShip { set { _secondShip = value; } }


        public override void Attack(object sender)
        {
            if ((Ship) sender == _firstShip)
            {
                _secondShip.Health -= _firstShip.Damage;
            }
            else
            {
                _firstShip.Health -= _secondShip.Damage;
            }
        }
    }
}
