namespace BeeX.Event
{
    public class OnTriggerExitEvent : EventBase
    {
        private void OnTriggerExit(UnityEngine.Collider other)
        {
            OnEvent.Invoke();            
        }
    } 
}
