using DesignPattern.Creational.AbstractFactory.Providers.Connections;

namespace DesignPattern.Creational.AbstractFactory.Providers.Commands
{
    public abstract class BaseCommand
    {
        public BaseCommand(BaseConnection cnn)
        {
            Connection = cnn;
        }
        public BaseConnection Connection { get; }
        public abstract void ExecuteQuery(string query);
    }
}
