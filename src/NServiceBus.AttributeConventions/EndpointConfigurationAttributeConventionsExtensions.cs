using NServiceBus.AttributeConventions.Contracts;
using System.Reflection;

namespace NServiceBus
{
    public static class EndpointConfigurationAttributeConventionsExtensions
    {
        public static void UseAttributeConventions(this EndpointConfiguration endpointConfiguration)
        {
            endpointConfiguration.Conventions()
                .DefiningMessagesAs(t => t.GetCustomAttribute<MessageAttribute>(false) != null)
                .DefiningCommandsAs(t => t.GetCustomAttribute<CommandAttribute>(false) != null)
                .DefiningEventsAs(t => t.GetCustomAttribute<EventAttribute>(false) != null);
        }
    }
}
