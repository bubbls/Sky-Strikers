using DG.Tweening;
using Moon.XRSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.LIV
{
	public abstract class LIVToggle : LIVButton
	{
		[SerializeField]
		protected Toggle _toggle;

		private Sequence _sequence;

		public void Toggle(bool isOn)
		{
		}

		protected override void HandleOnEnter(Collider other)
		{
		}

		public override void Press(UIInteractorType interactorType)
		{
		}

		protected virtual void HandleOnToggled()
		{
		}

		private void HandleOnValueChanged(bool isOn)
		{
		}

		protected virtual void UpdateVisuals(bool isOn)
		{
		}
	}
}
