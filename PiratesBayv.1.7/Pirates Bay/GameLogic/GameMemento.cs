using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Bay.GameLogic
{
    [Serializable]
    public class GameMemento
    {
        private Map _map;

        private List<Player> _players;

        private List<ShipYard> _playersShipsBuilders;

        private int _activePlayer;

        public GameMemento(Map map, List<Player> players, int activePlayer, List<ShipYard> playersShipsBuilders)
        {
            this._map = map;
            this._players = players;
            this._activePlayer = activePlayer;
            this._playersShipsBuilders = playersShipsBuilders;
        }

        public Map Map
        {
            get { return _map; }
        }

        public List<Player> Players
        {
            get { return _players; }
        }

        public List<ShipYard> ShipBuilders
        {
            get { return _playersShipsBuilders; }
        }

        public int ActivePlayerIndex
        {
            get { return _activePlayer; }
        }
    }
}
