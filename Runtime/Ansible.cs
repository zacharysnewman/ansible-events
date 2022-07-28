using AnsibleEvents.Aggregation;

namespace AnsibleEvents
{
    public static class Ansible
    {
        private static Aggregator EventAggregator { get; set; } = new Aggregator();
        public static TEventType Get<TEventType>() where TEventType : new() => EventAggregator.Get<TEventType>();
    }
}
