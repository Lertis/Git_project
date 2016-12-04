using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Bay.GameLogic
{
    [Serializable]
    public class ShipYard:ISerializable
    {
        public List<Ship> Ships { get; set; }

        public ShipYard()
        {
            Ships = new List<Ship>()
            {
                new Ship("Queen Anne`s Revenge", 2400, 250, 60,
                    @"..\Resources\Ships\Presentations\Queen Anne's Revenge.jpg", true, System.AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Ships\Models\Queen Anne's Revenge.png", false),
                new Ship("Old Pearl", 2000, 300, 65, @"..\Resources\Ships\Presentations\Old Pearl.jpg", true, System.AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Ships\Models\Old Pearl.png", false),
                new Ship("Pirate Brig", 1900, 270, 80, @"..\Resources\Ships\Presentations\Pirate Brig.jpg", true, System.AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Ships\Models\Pirate Brig.png", false),
                new Ship("The Ranger", 3600, 360, 70, @"..\Resources\Ships\Presentations\The Ranger.jpg", true, @"..\Resources\Ships\Models\The Ranger.png", true),
                new Ship("The Benjamin", 3300, 350, 120, @"..\Resources\Ships\Presentations\The Benjamin.jpg", true, @"..\Resources\Ships\Models\The Benjamin.png", true),
                new Ship("The Royal Fortune", 3500, 420, 60, @"..\Resources\Ships\Presentations\The Royal Fortune.jpg", true, @"..\Resources\Ships\Models\The Royal Fortune.png", true),
                new Ship("Black Pearl", 5000, 430, 75, @"..\Resources\Ships\Presentations\Black Pearl.jpg", true, @"..\Resources\Ships\Models\Black Pearl.png", true)
            };
        }

        public void UpgrageCannon(int gain)
        {
            foreach (var ship in Ships)
            {
                ship.UpgradeCannon(gain);
            }
        }

        public void UpgradeSails(int gain)
        {
            foreach (var ship in Ships)
            {
                ship.UpgradeSails(gain);
            }
        }

        public void UpgradeHull(int gain)
        {
            foreach (var ship in Ships)
            {
                ship.UpgradeHull(gain);
            }
        }

        public Ship BuildShip(String shipName)
        {
            return (Ship)Ships.First(ship => ship.Name.Equals(shipName)).Clone();
        }

        public ShipYard(SerializationInfo info, StreamingContext ctxt)
        {
            this.Ships = (List<Ship>) info.GetValue("Ships", typeof (List<Ship>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Ships", this.Ships);
        }
    }
}
