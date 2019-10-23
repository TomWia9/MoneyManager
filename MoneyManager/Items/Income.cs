using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManager.Items
{
    class Income:Item
    {
        public Income(int id, decimal amount, string name, DateTime date) : base(id, amount, name, date) { Type = ItemType.Income; }
    }
}
