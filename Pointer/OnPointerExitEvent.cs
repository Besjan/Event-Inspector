namespace BeeX.Event
{
    using UnityEngine.EventSystems;

    public class OnPointerExitEvent : PointerEvent, IPointerExitHandler
    {
        public void OnPointerExit(PointerEventData eventData)
        {
            if (eventData.button == Button)
                OnEvent.Invoke();
        }
    }
}
