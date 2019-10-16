using System;
using System.Collections.Generic;
using System.Text;
using MoneyManager.Items;

namespace MoneyManager.Statistics
{
    class List
    {
        private Item _item;

        public List(Item item)
        {
            _item = item;
        }

        public void DisplayLine()
        {
            Console.WriteLine("{0} {1} {2}zł {3}", _item.Id, _item.Name, _item.Amount, _item.Date);
        }
    }
}
