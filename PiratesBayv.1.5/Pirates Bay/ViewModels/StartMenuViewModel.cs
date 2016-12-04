using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pirates_Bay.ViewModels
{
    public class StartMenuViewModel
    {
        public ICommand MinimizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        public ICommand StartNewGameCommand { get; set; }
        public ICommand LoadGameCommand { get; set; }
        public ICommand LoadStatisticsCommand { get; set; }
        public ICommand ChangeOptionsCommand { get; set; }
    }
}
