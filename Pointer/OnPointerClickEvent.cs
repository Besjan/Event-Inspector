namespace BeeX.Event
{
    using System;
    using UnityEngine.EventSystems;

    public class OnPointerClickEvent : PointerEvent, IPointerDownHandler, IPointerClickHandler
    {
        private double clickTime = 200;
        private DateTime pointerDownTime;

        public void OnPointerDown(PointerEventData eventData)
        {
            pointerDownTime = DateTime.UtcNow;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            var pointerClickTime = (DateTime.UtcNow - pointerDownTime).TotalMilliseconds;

            if (eventData.button == Button && clickTime > pointerClickTime)
                OnEvent.Invoke();
        }
    }
}
