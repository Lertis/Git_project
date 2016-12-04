using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Bay.GameLogic
{
    [Serializable]
    public class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public List<MapSquare> Squares { get; set; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            Squares = new List<MapSquare>();

            var rand = new Random();

            int shipYardsCount = rand.Next(1, 4);

            int islandsCount = (int) ((rand.Next(10, 30)/100.0)*Height*Width);

            int treasuresCount = (int) ((Width*Height - islandsCount)*(rand.Next(15, 35)/100.0));

            while (shipYardsCount > 0)
            {
                Point shipYardPosition = new Point(rand.Next(0, Width), rand.Next(0, Height));

                if (Squares.All(s => s.Position != shipYardPosition))
                {
                    Squares.Add(new MapSquare() { Position = shipYardPosition, Type = MapSquareType.ShipYard });
                    shipYardsCount--;
                }
            }

            while (islandsCount > 0)
            {
                Point islandPosition = new Point(rand.Next(0, Width), rand.Next(0, Height));

                if (Squares.All(s => s.Position != islandPosition))
                {
                    Squares.Add(new MapSquare(){Position = islandPosition, Type = MapSquareType.Land});
                    islandsCount--;
                }
            }

            while (treasuresCount > 0)
            {
                Point treasurePosition = new Point(rand.Next(0, Width), rand.Next(0, Height));

                if (Squares.All(s => s.Position != treasurePosition))
                {
                    Squares.Add(new MapSquare() { Position = treasurePosition, Type = MapSquareType.Treasure });
                    treasuresCount--;
                }
            }

            for(int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    Point squarePosition = new Point(j, i);

                    if (Squares.All(s => s.Position != squarePosition))
                        Squares.Add(new MapSquare() { Position = squarePosition, Type = MapSquareType.Sea });
                }
        }

        public List<MapSquare> GetEnabledSquares(Point currentPosition, int radius)
        {
            List<MapSquare> enabledSquares = new List<MapSquare>();

            enabledSquares =
                Squares.Where(
                    s =>
                        ( (Math.Abs(s.Position.X - currentPosition.X) <= 1) &&
                         (Math.Abs(s.Position.Y - currentPosition.Y) <= 1) ) &&
                        ( (Math.Abs(s.Position.X - currentPosition.X) - Math.Abs(s.Position.Y - currentPosition.Y) != 0) ||
                         ((Squares.First(ds => ds.Position.X == s.Position.X && ds.Position.Y == currentPosition.Y).Type !=
                           MapSquareType.Land) &&
                          (Squares.First(ds => ds.Position.Y == s.Position.Y && ds.Position.X == currentPosition.X).Type !=
                           MapSquareType.Land)))
                         && s.Type != MapSquareType.Land ).ToList();

            if (radius > 1)
            {
                var tempList = enabledSquares;

                enabledSquares = new List<MapSquare>();

                foreach (var mapSquare in tempList)
                {
                    enabledSquares = enabledSquares.Union(GetEnabledSquares(mapSquare.Position, --radius)).ToList();
                }
            }
            return enabledSquares;
        }
 
    }
}
