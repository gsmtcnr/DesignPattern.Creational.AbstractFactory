using DesignPattern.Creational.AbstractFactory.Providers.Providers;
using System;

namespace DesignPattern.Creational.AbstractFactory.Providers
{
    public class ProviderFactoryMethod
    {
        private readonly string _providerTypeName;
        public ProviderFactoryMethod(string providerTypeName)
        {
            _providerTypeName = providerTypeName;
        }
        public BaseProvider CreateProviderByReflection()
        {
            Type providerType = Type.GetType("DesignPattern.Creational.AbstractFactory.Providers.Providers." + _providerTypeName);
            return (BaseProvider)Activator.CreateInstance(providerType);
        }
        public BaseProvider CreateProvider()
        {
            return _providerTypeName switch
            {
                "SQLProvider" => new SQLProvider(),
                "OracleProvider" => new OracleProvider(),
                _ => new DefaultProvider(),
            };
        }
    }
}
