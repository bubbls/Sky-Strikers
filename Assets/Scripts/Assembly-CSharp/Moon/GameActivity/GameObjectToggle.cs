using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.GameActivity
{
	public class GameObjectToggle : MonoBehaviour
	{
		[SerializeField]
		private GameObject _on;

		[SerializeField]
		private GameObject _off;

		[SerializeField]
		private bool _isOn;

		public bool IsOn => false;

		public event Action OnValueChanged
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

		private void OnValidate()
		{
		}

		public void Toggle()
		{
		}

		public void ForceToggle(bool enable, bool raiseEvent = true)
		{
		}
	}
}
