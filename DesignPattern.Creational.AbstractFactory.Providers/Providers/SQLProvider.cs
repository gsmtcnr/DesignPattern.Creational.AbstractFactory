using DesignPattern.Creational.AbstractFactory.Providers.Commands;
using DesignPattern.Creational.AbstractFactory.Providers.Connections;

namespace DesignPattern.Creational.AbstractFactory.Providers.Providers
{
    internal class SQLProvider : BaseProvider
    {
        public override BaseCommand CreateCommand(BaseConnection cnn)
        {
            return new SQLCommand(cnn);
        }

        public override BaseConnection CreateConnection()
        {
            return new SQLConnection();
        }
    }
}
