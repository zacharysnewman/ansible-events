using System.Collections;
using System.Collections.Generic;

namespace AnsibleEvents.Events
{
    public class AnsibleEventCoroutine : AnsibleEventBase
    {
        private HashSet<IEnumerator> Subscribers { get; set; } = new HashSet<IEnumerator>();

        public void Publish()
        {
            if (paused)
                return;

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
