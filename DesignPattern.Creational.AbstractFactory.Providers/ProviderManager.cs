using DesignPattern.Creational.AbstractFactory.Providers.Commands;
using DesignPattern.Creational.AbstractFactory.Providers.Connections;
using DesignPattern.Creational.AbstractFactory.Providers.Providers;

namespace DesignPattern.Creational.AbstractFactory.Providers
{
    public class ProviderManager
    {
        private readonly BaseProvider _provider;
        public ProviderManager()
        {
            //Let's assume the ProviderTypeName value comes from the app config.
            string providerTypeName = "SQLProvider";
            ProviderFactoryMethod providerFactoryMethod = new ProviderFactoryMethod(providerTypeName);
            _provider = providerFactoryMethod.CreateProvider();
        }
        public void Select(string query)
        {
            BaseConnection cnn = _provider.CreateConnection();
            BaseCommand cmd = _provider.CreateCommand(cnn);
            cmd.ExecuteQuery(query);
        }
    }
}
