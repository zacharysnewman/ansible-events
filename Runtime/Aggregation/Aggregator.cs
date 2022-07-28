using System;
using System.Collections.Generic;

namespace AnsibleEvents.Aggregation
{
    public class Aggregator
    {
        private Dictionary<Type, object> Subscribers { get; set; } = new Dictionary<Type, object>();
        public TEventType Get<TEventType>() where TEventType : new()
        {
            var eventType = typeof(TEventType);
            if (!Subscribers.ContainsKey(eventType))
            {
                Subscribers.Add(eventType, new TEventType());
            }
            return (TEventType)Subscribers[eventType];
        }
    }
}

