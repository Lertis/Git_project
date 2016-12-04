using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pirates_Bay.GameLogic;

namespace Pirates_Bay.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private PlayerViewModel _firstPlayer;
        private PlayerViewModel _secondPlayer;

        public PlayerViewModel FirstPlayer
        {
            get
            {
                return _firstPlayer;
            }
            set
            {
                _firstPlayer = value;
                OnPropertyChanged("FirstPlayer");
            }
        }

        public PlayerViewModel SecondPlayer
        {
            get
            {
                return _secondPlayer;
            }
            set
            {
                _secondPlayer = value; 
                OnPropertyChanged("SecondPlayer");
            }
        }

        public ICommand MinimizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        public ICommand ShowOptionsCommand { get; set; }
        public ICommand StartNewGameCommand { get; set; }
    }
}
