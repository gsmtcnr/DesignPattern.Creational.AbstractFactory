using DesignPattern.Creational.AbstractFactory.Providers.Commands;
using DesignPattern.Creational.AbstractFactory.Providers.Connections;

namespace DesignPattern.Creational.AbstractFactory.Providers.Providers
{
    internal class OracleProvider : BaseProvider
    {
        public override BaseCommand CreateCommand(BaseConnection cnn)
        {
            return new OracleCommand(cnn);
        }

        public override BaseConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
