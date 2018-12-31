namespace BeeX.Event
{
    using UnityEngine.EventSystems;

    public class PointerEvent : EventBase
    {
        [Sirenix.OdinInspector.PropertyOrder(1)]
        public PointerEventData.InputButton Button = PointerEventData.InputButton.Left;
    } 
}
