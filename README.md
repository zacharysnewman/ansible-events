# Ansible Events

A Pub/Sub Event Aggregator for Unity. It's really an "anything" aggregator, but it's very useful for aggregating events so they can be subscribed and published to without the subscriber and publisher directly referencing each other.

There are 3 different types of events included:
    AnsibleEventSync
    AnsibleEventAsync
    AnsibleEventCoroutine

Defining an event:
    using AnsibleEvents.Events;

    public class MySyncEventWithNoParameters : AnsibleEventSync {}

AnsibleEventSync and AnsibleEventAsync events can also be defined with 1-4 parameters:
    public class MySyncEventWithFourParameters : AnisbleEventSync<bool, int, float, string> {}

AnsibleEventCoroutine events can't be defined with parameters because coroutine methods can't receive arguments:
    public class MyCoroutineEvent : AnsibleEventCoroutine {}

Subscribe to an event:
    using AnsibleEvents;

    Ansible.Get<MyEvent>().Subscribe(SomeMethod);

Publish to an event:
    using AnsibleEvents;

    Ansible.Get<MyEvent>().Publish(SomeValue);