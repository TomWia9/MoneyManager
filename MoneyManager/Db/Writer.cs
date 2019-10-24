using MoneyManager.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MoneyManager.Db
{
    class Writer : IWriter
    {
        private string _filename;

        public Writer(string filename)
        {
            _filename = filename;
        }

        public void Remove(int id)
        {
            IEnumerable<string> lines = File.ReadAllLines(_filename);

            IList<string> toSave = new List<string>();

            foreach (string item in lines)
            {
                if (!(HasId(id, item))){

                    toSave.Add(item);
                }
            }

            File.WriteAllLines(_filename, toSave);
        }

        public void Write(Item item)
        {
            string line = ItemToText(item);
            File.AppendAllText(_filename, line);
        }

        private string ItemToText(Item item)
        {
            string type = "I";

            if (item.Type == ItemType.Outcome)
                type = "O";

            string line = string.Format("{0};{1};{2};{3};{4}", item.Id, item.Name, type, item.Amount, item.Date.ToString("dd-MM-yyyy"));

            return line + Environment.NewLine;
        }

        private bool HasId(int id, string line)
        {
            string[] columns = line.Split(';');

            int lineId = int.Parse(columns[0]);

            return id == lineId;
        }
    }
}
