using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnsibleEvents.Events.Base;

namespace AnsibleEvents.Events
{
    public class AnsibleEventAsync : AnsibleEventBase
    {
        private HashSet<Action> Subscribers { get; set; } = new HashSet<Action>();

        public async Task Publish()
        {
            if (paused)
                return;

            foreach (var subscriber in this.Subscribers)
            {
                await Task.Run(() => subscriber());
            }
        }

        public void Subscribe(Action at)
        {
            if (!this.Subscribers.Contains(at))
            {
                this.Subscribers.Add(at);
            }
        }

        public void Unsubscribe(Action at)
        {
            if (this.Subscribers.Contains(at))
            {
                this.Subscribers.Remove(at);
            }
        }
    }

    public class AnsibleEventAsync<T> : AnsibleEventBase
    {
        private HashSet<Action<T>> Subscribers { get; set; } = new HashSet<Action<T>>();

        public async Task Publish(T t)
        {
            if (paused)
                return;

            foreach (var subscriber in this.Subscribers)
            {
                await Task.Run(() => subscriber(t));
            }
        }

        public void Subscribe(Action<T> at)
        {
            if (!this.Subscribers.Contains(at))
            {
                this.Subscribers.Add(at);
            }
        }

        public void Unsubscribe(Action<T> at)
        {
            if (this.Subscribers.Contains(at))
            {
                this.Subscribers.Remove(at);
            }
        }
    }

    public class AnsibleEventAsync<T, U> : AnsibleEventBase
    {
        private HashSet<Action<T, U>> Subscribers { get; set; } = new HashSet<Action<T, U>>();

        public async Task Publish(T t, U u)
        {
            if (paused)
                return;

            foreach (var subscriber in this.Subscribers)
            {
                await Task.Run(() => subscriber(t, u));
            }
        }

        public void Subscribe(Action<T, U> at)
        {
            if (!this.Subscribers.Contains(at))
            {
                this.Subscribers.Add(at);
            }
        }

        public void Unsubscribe(Action<T, U> at)
        {
            if (this.Subscribers.Contains(at))
            {
                this.Subscribers.Remove(at);
            }
        }
    }

    public class AnsibleEventAsync<T, U, V> : AnsibleEventBase
    {
        private HashSet<Action<T, U, V>> Subscribers { get; set; } = new HashSet<Action<T, U, V>>();

        public async Task Publish(T t, U u, V v)
        {
            if (paused)
                return;

            foreach (var subscriber in this.Subscribers)
            {
                await Task.Run(() => subscriber(t, u, v));
            }
        }

        public void Subscribe(Action<T, U, V> at)
        {
            if (!this.Subscribers.Contains(at))
            {
                this.Subscribers.Add(at);
            }
        }

        public void Unsubscribe(Action<T, U, V> at)
        {
            if (this.Subscribers.Contains(at))
            {
                this.Subscribers.Remove(at);
            }
        }
    }

    public class AnsibleEventAsync<T, U, V, W> : AnsibleEventBase
    {
        private HashSet<Action<T, U, V, W>> Subscribers { get; set; } =
            new HashSet<Action<T, U, V, W>>();

        public async Task Publish(T t, U u, V v, W w)
        {
            if (paused)
                return;

            foreach (var subscriber in this.Subscribers)
            {
                await Task.Run(() => subscriber(t, u, v, w));
            }
        }

        public void Subscribe(Action<T, U, V, W> at)
        {
            if (!this.Subscribers.Contains(at))
            {
                this.Subscribers.Add(at);
            }
        }

        public void Unsubscribe(Action<T, U, V, W> at)
        {
            if (this.Subscribers.Contains(at))
            {
                this.Subscribers.Remove(at);
            }
        }
    }
}
