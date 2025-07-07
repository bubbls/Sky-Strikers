using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Hub
{
	[RequireComponent(typeof(ManualToggle))]
	public class HubMinimapPointOfInterest : MonoBehaviour
	{
		private const float DelayBetweenPresses = 1f;

		[SerializeField]
		private Transform _popupPoint;

		[SerializeField]
		[TextArea(3, 10)]
		private string _description;

		private ManualToggle _toggle;

		private float _nextPressTime;

		public Transform PopupPoint => null;

		public string Description => null;

		public event Action<HubMinimapPointOfInterest, bool> OnPOISelected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void ManualToggle_OnValueChanged()
		{
		}

		public void ResetToggle()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
