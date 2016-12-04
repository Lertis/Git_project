using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.GameLogic
{
    [Serializable]
    public class Ship:ViewModelBase, ICloneable, ISerializable
    {
        private String _name;
        private int _health;
        private int _speed;
        private int _damage;

        private BitmapImage _presentationImage;
        private BitmapImage _modelImage;

        public Point Position { get; set; }

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Health
        {
            get { return _health; }
            set
            {
                _health = value;
                OnPropertyChanged("Health");
            }
        }

        public int Damage
        {
            get { return _damage; }
            set
            {
                _damage = value;
                OnPropertyChanged("Damage");
            }
        }

        public int Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                OnPropertyChanged("Speed");
            }
        }

        public BitmapImage PresentationImage
        {
            get { return _presentationImage; }
            set
            {
                _presentationImage = value;
                OnPropertyChanged("PresentationImage");
            }
        }

        public BitmapImage ModelImage
        {
            get { return _modelImage; }
            set
            {
                _modelImage = value;
                OnPropertyChanged("ModelImage");
            }
        }

        public Ship(String name, int health, int damage, int speed, String presentationImagePath, bool presentationPathIsRelative, String modelImagePath, bool modelPathIsRelative)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Speed = speed;

            if (!String.IsNullOrEmpty(presentationImagePath))
            {
                Uri imageSourcePath;

                if (presentationPathIsRelative)
                    imageSourcePath = new Uri(presentationImagePath, UriKind.Relative);
                else
                    imageSourcePath = new Uri(presentationImagePath);

                PresentationImage = new BitmapImage(imageSourcePath);
            }

            if (!String.IsNullOrEmpty(modelImagePath))
            {
                Uri imageSourcePath;

                if (modelPathIsRelative)
                    imageSourcePath = new Uri(modelImagePath, UriKind.Relative);
                else
                    imageSourcePath = new Uri(modelImagePath);

                ModelImage = new BitmapImage(imageSourcePath);
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void UpgradeCannon(int gain)
        {
            if (gain <= 0)
                throw new ArgumentOutOfRangeException("gain", "Upgrage gain must has value above 0.");

            Damage += gain;
        }

        public void UpgradeHull(int gain)
        {
            if(gain <= 0)
                throw new ArgumentOutOfRangeException("gain", "Upgrade gain must has value above 0.");

            Health += gain;
        }

        public void UpgradeSails(int gain)
        {
            if (gain <= 0)
                throw new ArgumentOutOfRangeException("gain", "Upgrade gain must has value above 0.");

            Speed += gain;
        }

        public int CalculateCost()
        {
            return Health*4 + Damage*30 + Speed*50;
        }

        public Ship() { }

        public Ship(SerializationInfo info, StreamingContext ctxt)
        {
            this._name = info.GetString("Name");
            this._damage = info.GetInt32("Damage");
            this._health = info.GetInt32("Health");
            this._speed = info.GetInt32("Speed");
            this.Position = (Point) info.GetValue("Position", typeof (Point));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this._name);
            info.AddValue("Damage", this._damage);
            info.AddValue("Speed", this._speed);
            info.AddValue("Health", this._health);
            info.AddValue("Position", this.Position);
        }
    }
}
