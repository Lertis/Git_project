using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pirates_Bay.GameLogic
{
    class GameCaretaker
    {
        private GameMemento _memento;

        public GameCaretaker() { }

        public GameCaretaker(GameMemento memento)
        {
            SetMemento(memento);
        }

        public void SetMemento(GameMemento memento)
        {
            this._memento = memento;
        }

        public GameMemento GetMemento()
        {
            return _memento;
        }

        public void LoadGame(String fileName)
        {
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                try
                {
                    var formatter = new BinaryFormatter();

                    SaveDescription details = (SaveDescription) formatter.Deserialize(stream);

                    _memento = (GameMemento) formatter.Deserialize(stream);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void SaveGame()
        {
            using (
                Stream stream =
                    new FileStream(
                        "Saves\\" + _memento.Players[0].Name + "vs" + _memento.Players[1].Name +
                        DateTime.Now.ToShortDateString() + ".pbs", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                try
                {
                    var saveDetails = new SaveDescription()
                    {
                        FirstPlayer = _memento.Players[0].Name,
                        SecondPlayer = _memento.Players[1].Name,
                        Date = DateTime.Now
                    };

                    var formatter = new BinaryFormatter();

                    formatter.Serialize(stream,saveDetails);
                    formatter.Serialize(stream, _memento);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
