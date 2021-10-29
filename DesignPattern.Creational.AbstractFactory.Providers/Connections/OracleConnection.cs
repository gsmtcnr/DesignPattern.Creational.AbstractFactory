using System;

namespace DesignPattern.Creational.AbstractFactory.Providers.Connections
{
    internal class OracleConnection : BaseConnection
    {
        public override void Close()
        {
            Console.WriteLine(nameof(OracleConnection) + " is closed");
        }

        public override void Open()
        {
            Console.WriteLine(nameof(OracleConnection) + " is opened");
        }
    }
}
