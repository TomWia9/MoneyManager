using MoneyManager.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManager.Db
{
    interface IReader
    {
        IEnumerable<Item> ReadAll();
        int GetNextId();
    }
}
