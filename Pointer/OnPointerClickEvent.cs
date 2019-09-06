namespace Cuku.Event
{
	using UnityEngine;
	using UnityEngine.EventSystems;

	public class OnPointerClickEvent : PointerEvent, IPointerDownHandler, IPointerClickHandler
	{
		[SerializeField]
		private double clickCount = 1;
		[SerializeField]
		private float clickTime = 0.2f;

		private float pointerDownTime;
		private float lastClickTime;

		private int clicksMade;

		public void OnPointerDown(PointerEventData eventData)
		{
			pointerDownTime = Time.time;
		}

		public void OnPointerClick(PointerEventData eventData)
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
				clicksMade = 0;
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
					OnEvent.Invoke();
					clicksMade = 0;
				}
			}
			else
			{
				clicksMade = 0;
			}

			lastClickTime = Time.time;
		}
	}
}
