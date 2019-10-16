using MoneyManager.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManager.Db
{
    interface IWriter
    {
        void Write(Item item);
    }
}
