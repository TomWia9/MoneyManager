using System;

namespace MoneyManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Income income = new Income();
            income.Id = 1;
            income.Name = "Pensja";
            income.Amount = 1500.0M;
            income.Date = new DateTime(2019,10,14);

            Console.WriteLine("{0} {1} {2}zł {3}", income.Id, income.Name, income.Amount, income.Date);

            Console.ReadKey();
        }
    }
}
