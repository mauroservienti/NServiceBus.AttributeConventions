using NServiceBus.AttributeConventions.Contracts;
using System.Reflection;
using NServiceBus.AttributeConventions;

namespace NServiceBus
{
    public static class EndpointConfigurationAttributeConventionsExtensions
    {
        public static void UseAttributeConventions(this EndpointConfiguration endpointConfiguration)
        {
            endpointConfiguration.Conventions().Add(new MessageAttributeConventions());
        }
    }
}
