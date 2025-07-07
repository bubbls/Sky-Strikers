using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Moon
{
	[RequireComponent(typeof(InputField))]
	public class VRInputFieldInjector : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		private InputField _inputField;

		public event Action<InputField> OnFocused
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

		private void Awake()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
