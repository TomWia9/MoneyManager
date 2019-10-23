using System;
using System.Collections.Generic;
using System.Text;
using MoneyManager.Db;
using MoneyManager.Items;

namespace MoneyManager
{
    class Service
    {
        private IReader _reader;
        private IWriter _writer;

        public Service(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void AddIncome(decimal amount, string name, DateTime date)
        {
            int id = _reader.GetNextId();

            Income income = new Income(id, amount, name, date);
            _writer.Write(income);
        }

        public void AddOutcome(decimal amount, string name, DateTime date)
        {
            int id = _reader.GetNextId();

            Outcome outcome = new Outcome(id, amount, name, date);
            _writer.Write(outcome);
        }

        public void RemoveById(int id)
        {
            _writer.Remove(id);
        }
    }
}
