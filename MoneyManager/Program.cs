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
            Income income = new Income
            {
                Id = 1,
                Name = "Pensja",
                Amount = 1500.0M,
                Date = new DateTime(2019, 10, 5)
            };

            Outcome outcome = new Outcome
            {
                Id = 1,
                Name = "Zakupy",
                Amount = 120.50M,
                Date = new DateTime(2019, 10, 6)
            };

            Console.WriteLine("Przychód:\n{0} {1} {2}zł {3}", income.Id, income.Name, income.Amount, income.Date);
            Console.WriteLine("Wydatek:\n{0} {1} {2}zł {3}", outcome.Id, outcome.Name, outcome.Amount, outcome.Date);

            Console.ReadKey();
        }
    }
}
