using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Bay.GameLogic
{
    [Serializable]
    public class Player
    {
        public String Name { get; set; }

        public Ship Ship { get; set; }

        public int Gold { get; set; }
    }
}
