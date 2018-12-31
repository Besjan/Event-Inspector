namespace BeeX.Event
{
    public class OnTriggerEnterEvent : EventBase
    {
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            OnEvent.Invoke();            
        }
    } 
}
