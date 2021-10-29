using System;

namespace DesignPattern.Creational.AbstractFactory.Providers.Connections
{
    internal class SQLConnection : BaseConnection
    {
        public override void Close()
        {
            Console.WriteLine(nameof(SQLConnection) + " is closed");
        }

        public override void Open()
        {
            Console.WriteLine(nameof(SQLConnection) + "  is opened");
        }
    }
}
