using System.Collections;
using System.Collections.Generic;

namespace AnsibleEvents.Events
{
    public class AnsibleEventCoroutine
    {
        private HashSet<IEnumerator> Subscribers { get; set; } = new HashSet<IEnumerator>();

        public void Publish()
        {
            foreach (var subscriber in this.Subscribers)
            {
                CoroutineBehaviour.Self.StartCoroutine(subscriber);
            }
        }
        public void Subscribe(IEnumerator coroutine)
        {
            if (!this.Subscribers.Contains(coroutine))
            {
                this.Subscribers.Add(coroutine);
            }
        }
        public void Unsubscribe(IEnumerator coroutine)
        {
            if (this.Subscribers.Contains(coroutine))
            {
                this.Subscribers.Remove(coroutine);
            }
        }
    }
}
