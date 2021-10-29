using DesignPattern.Creational.AbstractFactory.Providers.Connections;
using System;

namespace DesignPattern.Creational.AbstractFactory.Providers.Commands
{
    internal class OracleCommand : BaseCommand
    {
        public OracleCommand(BaseConnection cnn) : base(cnn)
        {
        }

        public override void ExecuteQuery(string query)
        {
            Connection.Open();
            Console.WriteLine("Query executed on " + nameof(OracleCommand) + " " + query);
            Connection.Close();
        }
    }
}
