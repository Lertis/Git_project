using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirates_Bay.BehavioralPatterns;

namespace Pirates_Bay.StructuralPatterns
{
    public class Ship
    {
        protected Mediator Mediator;

        public int Speed { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Ship(int health, int speed, int damage, Point position)
        {
            Health = health;
            Speed = speed;
            Damage = damage;

            Position = position;
        }
        public Point Position { get; set; }

        public virtual void Attack(Ship enemy)
        {
            enemy.Health -= Damage;
        }

        public void Move(Point newPosition)
        {
            Position = newPosition;
        }

        public void SetMediator(Mediator mediator)
        {
            Mediator = mediator;
        }

        public void Attack()
        {
            Mediator.Attack(this);
        }
    }
}
