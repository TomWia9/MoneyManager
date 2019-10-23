using System;
using System.Collections.Generic;
using System.Text;
using MoneyManager.Items;
using MoneyManager.Db;

namespace MoneyManager.Statistics
{
    class List
    {
        private IReader _reader;

        public List(IReader reader)
        {
            _reader = reader;
        }

        public void DisplayList()
        {
            IEnumerable<Item> list = _reader.ReadAll();

            foreach (Item item in list)
            {
                DisplayLine(item);
            }
        }

        private void DisplayLine(Item item)
        {
            string type="";

            switch (item.Type)
            {
                case ItemType.Income:
                    type = "DOCHÓD";
                    break;
                case ItemType.Outcome:
                    type = "WYDATEK";
                    break;
            }

            Console.WriteLine("{0} {1} {2} {3}zł {4}", item.Id, item.Name, type, item.Amount, item.Date);
        }
    }
}
