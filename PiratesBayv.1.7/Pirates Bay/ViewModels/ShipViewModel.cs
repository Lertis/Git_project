using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Pirates_Bay.GameLogic;

namespace Pirates_Bay.ViewModels
{
    public class ShipViewModel: ViewModelBase
    {
        private Ship _ship;

        public ShipViewModel(Ship ship)
        {
            this._ship = ship;
        }

        public ShipViewModel(string name, int health, int damage, int speed, string presentationImagePath, bool presentationIsRelative, string modelImagePath, bool modelPathIsRelative)
        {
            _ship = new Ship(name, health, damage, speed, presentationImagePath, presentationIsRelative, modelImagePath, modelPathIsRelative);
        }

        public String ShipName
        {
            get { return _ship.Name; }
            set
            {
                _ship.Name = value;
                OnPropertyChanged("ShipName");
            }
        }

        public int ShipHealth
        {
            get { return _ship.Health; }
            set
            {
                _ship.Health = value;
                OnPropertyChanged("ShipHealth");
            }
        }

        public int ShipDamage
        {
            get { return _ship.Damage; }
            set
            {
                _ship.Damage = value;
                OnPropertyChanged("ShipDamage");
            }
        }

        public int ShipSpeed
        {
            get { return _ship.Speed; }
            set
            {
                _ship.Speed = value;
                OnPropertyChanged("ShipSpeed");
            }
        }

        public BitmapImage ShipPresentationImage
        {
            get { return _ship.PresentationImage; }
            set
            {
                _ship.PresentationImage = value;
                OnPropertyChanged("ShipPresentationImage");
            }
        }

        public BitmapImage ShipModelImage
        {
            get { return _ship.ModelImage; }
            set
            {
                _ship.ModelImage = value;
                OnPropertyChanged("ShipModelImage");
            }
        }

        public Ship GetShipInstance()
        {
            return _ship;
        }
    }
}
