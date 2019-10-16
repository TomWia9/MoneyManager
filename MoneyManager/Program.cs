using System;
using MoneyManager.Items;
using MoneyManager.Db;
using MoneyManager.Statistics;

namespace MoneyManager
{
    class Program
    {
        static void Main()
        {
            IReader database = new File();

            Item income = database.Read();

            List list = new List(income);
            list.DisplayLine();
            
            Console.ReadKey();
        }
    }
}
