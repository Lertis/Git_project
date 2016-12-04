using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Bay.GameLogic
{
    [Serializable]
    public class MapSquare
    {
        public Point Position { get; set; }
        public MapSquareType Type { get; set; }

        public static bool operator ==(MapSquare a, MapSquare b)
        {
            if (object.ReferenceEquals((object)a, (object)b))
                return true;

            if ( ((object)a) == null || ((object)b) == null)
                return false;
            else
                return a.Position == b.Position && a.Type == b.Type;
        }

        public static bool operator !=(MapSquare a, MapSquare b)
        {
            return !(a == b);
        }

        public bool Equals(MapSquare other)
        {
            if (object.ReferenceEquals((object)null, (object)other))
                return false;
            if (object.ReferenceEquals((object)this, (object)other))
                return true;
            else
                return this.Position == other.Position && this.Type == other.Type;
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals((object)null, obj))
                return false;
            if (object.ReferenceEquals((object)this, obj))
                return true;
            if (obj.GetType() != typeof(MapSquare))
                return false;
            else
                return this.Equals((MapSquare)obj);
        }

        public override int GetHashCode()
        {
            return (this.Position.ToString() + this.Type.ToString()).GetHashCode();
        }
    }
}


