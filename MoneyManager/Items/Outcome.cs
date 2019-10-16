using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManager.Items
{
    class Outcome:Item
    {
        public Outcome(int id, decimal amount, string name, DateTime date) : base(id, amount, name, date) { }
    }
}
