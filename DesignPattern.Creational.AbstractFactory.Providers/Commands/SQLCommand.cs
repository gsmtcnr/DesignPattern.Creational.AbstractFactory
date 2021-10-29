using DesignPattern.Creational.AbstractFactory.Providers.Connections;
using System;

namespace DesignPattern.Creational.AbstractFactory.Providers.Commands
{
    internal class SQLCommand : BaseCommand
    {
        public SQLCommand(BaseConnection cnn) : base(cnn)
        {
        }

        public override void ExecuteQuery(string query)
        {
            Connection.Open();
            Console.WriteLine("Query executed on " + nameof(SQLCommand) + " " + query);
            Connection.Close();
        }
    }
}
