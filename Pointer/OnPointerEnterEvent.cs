namespace BeeX.Event
{
    using UnityEngine.EventSystems;

    public class OnPointerEnterEvent : PointerEvent, IPointerEnterHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {
            if (eventData.button == Button)
                OnEvent.Invoke();
        }
    }
}
