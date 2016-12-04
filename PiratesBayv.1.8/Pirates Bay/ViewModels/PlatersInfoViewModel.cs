using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pirates_Bay.ViewModels
{
    public class PlayersInfoViewModel
    {
        public String FirstPlayerName { get; set; }
        public String SecondPlayerName { get; set; }

        public String FirstPlayerShipName { get; set; }
        public String SecondPlayerShipName { get; set; }

        public ICommand MinimizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand StartPlayCommand { get; set; }
    }
}
