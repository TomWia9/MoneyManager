using System;
using MoneyManager.Items;

namespace MoneyManager.Db
{
    class File:IReader,IWriter
    {
        public Item Read()
        {
           return new Income(1, 1500.0M, "Pensja", new DateTime(2019, 10, 4));
        }

        public void Write(Item item)
        {
            
        }
    }
}
