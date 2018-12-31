namespace BeeX.Event
{
    using ByteSheep.Events;
    using Sirenix.OdinInspector;

    [HideMonoScript]
    public abstract class EventBase : SerializedMonoBehaviour
    {
        [DrawWithUnity]
        [PropertyOrder(2)]
        public AdvancedEvent OnEvent;
    }
}
