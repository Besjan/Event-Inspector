namespace BeeX.Event
{
    public class OnDisableEvent : EventBase
    {
        private void OnDisable()
        {
            OnEvent.Invoke();
        }
    } 
}
