namespace AnsibleEvents.Events.Base
{
    public class AnsibleEventBase
    {
        private bool paused = false;

        public void Pause()
        {
            paused = true;
        }

        public void Resume()
        {
            paused = false;
        }
    }
}
