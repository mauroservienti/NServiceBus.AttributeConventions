using System;
using System.Reflection;
using NServiceBus.AttributeConventions.Contracts;

namespace NServiceBus.AttributeConventions
{
    class MessageAttributeConventions : IMessageConvention
    {
        public string Name { get; } = "Attribute decorator";
        public bool IsCommandType(Type t) => t.GetCustomAttribute<CommandAttribute>(false) != null;
        public bool IsEventType(Type t) => t.GetCustomAttribute<EventAttribute>(false) != null;
        public bool IsMessageType(Type t) => t.GetCustomAttribute<MessageAttribute>(false) != null;
    }
}