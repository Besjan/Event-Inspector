namespace BeeX.Event
{
    public class OnEnableEvent : EventBase
    {
        private void OnEnable()
        {
            OnEvent.Invoke();
        }
    } 
}
