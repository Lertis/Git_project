using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Bay.GameLogic
{
    [Serializable]
    class SaveDescription
    {
        public String FirstPlayer { get; set; }
        public String SecondPlayer { get; set; }
        public DateTime Date { get; set; }
    }
}
