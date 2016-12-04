using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirates_Bay.GameLogic;

namespace Pirates_Bay.ViewModels
{
    public class PlayerViewModel: ViewModelBase
    {
        private String _name;

        private Ship _ship;

        private int _gold;

        public Ship Ship
        {
            get { return _ship; }
            set
            {
                _ship = value;
                OnPropertyChanged("Ship");
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public PlayerViewModel(Ship ship, String name, int gold)
        {
            if(ship != null)
                this.Ship = ship;

            this.Name = name;
            this.Gold = gold;
        }
    }
}
