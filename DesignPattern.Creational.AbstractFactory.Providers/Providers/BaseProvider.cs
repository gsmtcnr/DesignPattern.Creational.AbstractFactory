using DesignPattern.Creational.AbstractFactory.Providers.Commands;
using DesignPattern.Creational.AbstractFactory.Providers.Connections;

namespace DesignPattern.Creational.AbstractFactory.Providers.Providers
{
    public abstract class BaseProvider
    {
        public abstract BaseConnection CreateConnection();
        public abstract BaseCommand CreateCommand(BaseConnection baseConnection);
    }
}
