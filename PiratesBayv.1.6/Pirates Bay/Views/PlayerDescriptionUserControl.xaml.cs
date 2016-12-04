using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for PlayerDescriptionUserControl.xaml
    /// </summary>
    public partial class PlayerDescriptionUserControl : UserControl, INotifyPropertyChanged
    {
        public PlayerDescriptionUserControl()
        {
            InitializeComponent();
        }

        private PlayerViewModel _player;

        public PlayerViewModel Player
        {
            get
            {
                return _player;
            }
            set
            {
                _player = value;
                OnPropertyChanged("Player");
            }
        }

        public static DependencyProperty PlayerProperty = DependencyProperty.Register("Player", typeof (PlayerViewModel),
            typeof (PlayerDescriptionUserControl));

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler changeHandler = PropertyChanged;

            if (changeHandler != null)
            {
                changeHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
