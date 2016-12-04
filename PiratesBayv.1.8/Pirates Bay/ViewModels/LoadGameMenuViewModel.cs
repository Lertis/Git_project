using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pirates_Bay.ViewModels
{
    public class LoadGameMenuViewModel
    {
        public ICommand LoadCommand { get; set; }
        public ICommand MinimizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
    }
}
