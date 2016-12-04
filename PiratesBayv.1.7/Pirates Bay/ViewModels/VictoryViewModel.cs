using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pirates_Bay.ViewModels
{
    public class VictoryViewModel: ViewModelBase
    {
        private String _caption;

        public String Text
        {
            get { return _caption; }
            set
            {
                _caption = value;
                OnPropertyChanged("Text");
            }
        }

        public ICommand MinimizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
    }
}
