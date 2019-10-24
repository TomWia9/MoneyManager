using System;
using MoneyManager.Items;
using MoneyManager.Db.Files;
using MoneyManager.Db;
using MoneyManager.Statistics;

namespace MoneyManager
{
    class Program
    {
        static IReader _reader;
        static IWriter _writer;

        static void Main()
        {
            _reader = new Reader("database.txt");
            _writer = new Writer("database.txt");
            string selected;

            do
            {
                DisplayMenu();
                selected = Console.ReadLine();
                RunSelected(selected);

            } while (selected!="6");
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Lista");
            Console.WriteLine("2 - Raport miesięczny");
            Console.WriteLine("3 - Dodaj wydatek");
            Console.WriteLine("4 - Dodaj dochód");
            Console.WriteLine("5 - Usuń pozycję");
            Console.WriteLine("6 - Zakończ");
            Console.Write(">: ");
        }

        private static void RunSelected(string selected)
        {
            switch (selected)
            {
                case "1":
                    ShowList();
                    break;
                case "2":
                    ShowRaport();
                     break;
                case "3":
                    AddOutcome();
                    break;
                case "4": 
                    AddIncome();
                    break;
                case "5":
                    RemoveItem();
                    break;
            }
        }

        private static void ShowList()
        {
            Console.Clear();
            Console.WriteLine("Wszystkie pozycje:");

            List list = new List(_reader);
            list.DisplayList();
           
            Console.ReadKey();
        }

        private static void ShowRaport()
        {
            Console.Clear();

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            Summary report = new Summary(_reader);

            report.DisplayReport(year, month);
            Console.ReadKey();
        }

        private static void AddOutcome()
        {
            Console.Clear();
            Console.WriteLine("Nowy wydatek");

            Console.Write("Nazwa: ");
            string name = Console.ReadLine();

            Console.Write("Kwota: ");
            string value = Console.ReadLine();
            decimal amount = decimal.Parse(value);

            Console.Write("Data: ");
            value = Console.ReadLine();
            DateTime date = DateTime.Parse(value);

            Service service = new Service(_reader, _writer);
            service.AddOutcome(amount, name, date);
        }

        private static void AddIncome()
        {
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Nowy dochód");

            Console.Write("Nazwa: ");
            string name = Console.ReadLine();

            Console.Write("Kwota: ");
            string value = Console.ReadLine();
            decimal amount = decimal.Parse(value);

            Console.Write("Data: ");
            value = Console.ReadLine();
            DateTime date = DateTime.Parse(value);

            Service service = new Service(_reader, _writer);
            service.AddIncome(amount, name, date);
        }

        private static void RemoveItem()
        {
            Console.Clear();
            Console.Write("Podaj id do usuniecia: ");

            string value = Console.ReadLine();
            int id = int.Parse(value);

            Service service = new Service(_reader, _writer);
            service.RemoveById(id);
        }
    }
}
