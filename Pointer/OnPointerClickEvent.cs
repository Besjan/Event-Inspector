namespace Cuku.Event
{
    using UnityEngine;
	using UnityEngine.EventSystems;

	public class OnPointerClickEvent : PointerEvent, IPointerDownHandler, IPointerUpHandler
	{
		[SerializeField]
		private double clickCount = 1;
		[SerializeField]
		private float clickTime = 0.2f;

        [Sirenix.OdinInspector.PropertyOrder(3)]
		public ByteSheep.Events.AdvancedEvent OnFail;

		private float pointerDownTime;
		private float lastClickTime;

		private int clicksMade;

		public void OnPointerDown(PointerEventData eventData)
		{
			pointerDownTime = Time.time;
		}

		public void OnPointerUp(PointerEventData eventData)
		{
			if (eventData.button != Button)
				return;

			// Valid click
			if (clickTime > Time.time - pointerDownTime)
			{
				UpdateClicks();
			}
			else
			{
				Failed();
			}
		}

		void UpdateClicks()
		{
			clicksMade++;

			// Valid multiple click
			if (clicksMade == 1 || clickTime > Time.time - lastClickTime)
			{
				if (clickCount == clicksMade)
				{
					CancelInvoke();
					OnEvent.Invoke();
					clicksMade = 0;
					return;
				}
			}
			else
			{
				Failed();
			}

			lastClickTime = Time.time;

			Invoke("Failed", clickTime);
		}

		void Failed()
		{
			clicksMade = 0;
			OnFail.Invoke();
		}
	}
}
