using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManager
{
    abstract class Item
    {
        public int Id;
        public string Name;
        public decimal Amount;
        public DateTime Date;
    }
}
