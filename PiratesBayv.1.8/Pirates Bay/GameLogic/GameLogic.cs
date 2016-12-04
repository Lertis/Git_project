using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pirates_Bay.GameLogic
{
    public class GameLogic
    {
        public Map Map { get; set; }

        public List<Player> Players { get; set; }

        public List<ShipYard> PlayersShipsBuilders { get; set; }

        public ShipYard ShipYard { get; set; }

        public int ActivePlayer { get; set; }
        public int MovementsLeft { get; set; }
        public bool CanAttack { get; set; }
        public bool UpgradingShip { get; set; }
   
        public delegate void ShipEventsHandler(Ship sender);

        public delegate void PlayerActionEventHandler(Player sender);

        public delegate void CollectResourceEventHandler(Player sender, Point treasurePosition);

        public delegate void ShipMoveEventHandler(Ship sender, List<Point> route);

        public event ShipEventsHandler DisplayShip;
        public event ShipEventsHandler DestroyShip;
        public event ShipEventsHandler AttackedEnemy;

        public event ShipMoveEventHandler ShipMoved;

        public event PlayerActionEventHandler PlayerActivated;
        public event PlayerActionEventHandler PlayerWon;

        public event EventHandler ShowShipYard;

        public event CollectResourceEventHandler TreasureCollected;

        public GameLogic()
        {
            ShipYard = new ShipYard();
        }

        public void Initialize(String firstPlayerName, String firstPlayerShipName, String secondPlayerName,
            String secondPlayerShipName)
        {
            PlayersShipsBuilders = new List<ShipYard>() {new ShipYard(), new ShipYard()};

            Players = new List<Player>(){
             new Player() {Name = firstPlayerName, Ship = ShipYard.BuildShip(firstPlayerShipName), Gold = 0},

             new Player() {Name = secondPlayerName, Ship = ShipYard.BuildShip(secondPlayerShipName), Gold = 0}};

            Map = new Map(14,8);

            Point firstPlayerShipPosition = Point.Empty, secondPlayerShipPosition = Point.Empty;
            bool firstPositionNotFinded = true, secondPositionNotFinded = true;
            var enabledSquares =  Map.Squares.Where(s => s.Type == MapSquareType.Sea).ToList();

            while (firstPositionNotFinded)
            {
                int x = new Random().Next(0, Map.Width);
                int y = new Random().Next(0, Map.Height);
                var firstShipSquare = enabledSquares.FirstOrDefault(s => s.Position.X == x && s.Position.Y == y);

                if (firstShipSquare != null)
                {
                    firstPlayerShipPosition = firstShipSquare.Position;
                    firstPositionNotFinded = false;
                }
            }
            
            while (secondPositionNotFinded)
            {
                var secondShipSquare = Map.Squares.FirstOrDefault(
                    s =>
                        (s.Type == MapSquareType.Sea) &&
                        (Math.Max(Math.Abs(s.Position.X - firstPlayerShipPosition.X),
                            Math.Abs(s.Position.Y - firstPlayerShipPosition.Y)) > 6));

                if (secondShipSquare != null)
                {
                    secondPlayerShipPosition = secondShipSquare.Position;
                    secondPositionNotFinded = false;
                }
            }

            Players[0].Ship.Position = firstPlayerShipPosition;
            Players[1].Ship.Position = secondPlayerShipPosition;

            ActivePlayer = 0;
        }

        public GameMemento CreateGameMemento()
        {
            return new GameMemento(Map, Players, ActivePlayer, PlayersShipsBuilders);
        }

        public void SetGameMemento(GameMemento memento)
        {
            this.Players = memento.Players;
            this.PlayersShipsBuilders = memento.ShipBuilders;
            this.ActivePlayer = memento.ActivePlayerIndex;
            this.Map = memento.Map;

            foreach (var playersShipsBuilder in PlayersShipsBuilders)
            {
                for (int i = 0; i < playersShipsBuilder.Ships.Count; i++)
                {
                    playersShipsBuilder.Ships[i].ModelImage = ShipYard.Ships[i].ModelImage;
                    playersShipsBuilder.Ships[i].PresentationImage = ShipYard.Ships[i].PresentationImage;
                }
            }

            foreach (var player in Players)
            {
                var shipPrototype = ShipYard.Ships.Find(s => s.Name == player.Ship.Name);

                player.Ship.ModelImage = shipPrototype.ModelImage;
                player.Ship.PresentationImage = shipPrototype.PresentationImage;
            }
        }

        public void Start()
        {
            UpgradingShip = false;

            DisplayShip(Players[0].Ship);
            DisplayShip(Players[1].Ship);

            ActivatePlayer(Players[ActivePlayer]);
        }

        public void ActivatePlayer(Player player)
        {
            ActivePlayer = Players.FindIndex(p => p.Ship.Position == player.Ship.Position);
            MovementsLeft = player.Ship.Speed/60;
            CanAttack = true;

            PlayerActivated(player);
        }

        public void RecognizeUserAction(Point clickPosition)
        {
            var square = Map.Squares.Find(s => s.Position == clickPosition);

            var enemy = Players.Find(p => p.Ship.Position != Players[ActivePlayer].Ship.Position);

            var mayAttack = (enemy.Ship.Position == clickPosition) &&
                            (Math.Max(Math.Abs(Players[ActivePlayer].Ship.Position.X - enemy.Ship.Position.X),
                                Math.Abs(Players[ActivePlayer].Ship.Position.Y - enemy.Ship.Position.Y)) < 2);
            if (mayAttack)
            {
                if(CanAttack)
                    Attack(Players[ActivePlayer], enemy);
            }
            else
            {
                if( (clickPosition != Players[ActivePlayer].Ship.Position) && (MovementsLeft > 0) )
                    MoveTo(Players[ActivePlayer].Ship, clickPosition);
            }

            if (enemy.Ship.Health <= 0)
            {
                PlayerWon(Players[ActivePlayer]);
                return;
            }

            mayAttack = (Math.Max(Math.Abs(Players[ActivePlayer].Ship.Position.X - enemy.Ship.Position.X),
                                Math.Abs(Players[ActivePlayer].Ship.Position.Y - enemy.Ship.Position.Y)) < 2);

            if ((!CanAttack || !mayAttack)  && (MovementsLeft <= 0) && !UpgradingShip)
            {
                ActivatePlayer(Players.Find(p=>p.Ship.Position != Players[ActivePlayer].Ship.Position));
            }
        }

        private void Attack(Player currentPlayer, Player enemy)
        {
            AttackedEnemy(currentPlayer.Ship);

            CanAttack = false;

            if (enemy.Ship.Health > currentPlayer.Ship.Damage)
            {
                enemy.Ship.Health -= currentPlayer.Ship.Damage;
            }
            else
            {
                enemy.Ship.Health = 0;
            }
        }

        private void MoveTo(Ship ship, Point newPosition)
        {
            var oldPos = ship.Position;
            ship.Position = newPosition;

            ShipMoved(ship, new List<Point>() { oldPos, newPosition});


            var square = Map.Squares.Find(s => s.Position == newPosition);

            if (square.Type == MapSquareType.Treasure)
            {
                Players[ActivePlayer].Gold += new Random().Next(5, 31)*100;

                square.Type = MapSquareType.Sea;

                TreasureCollected(Players[ActivePlayer], square.Position);
            }

            if (square.Type == MapSquareType.ShipYard)
            {
                UpgradingShip = true;
                ShowShipYard(null, null);
            }

            MovementsLeft--;
        }
    }
}
