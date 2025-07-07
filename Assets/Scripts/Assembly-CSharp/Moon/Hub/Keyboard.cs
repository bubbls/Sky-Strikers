using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Hub
{
	public class Keyboard : MonoBehaviour
	{
		[SerializeField]
		private KeyboardKey[] _keys;

		public event Action<string> OnKeyPressed
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleKeyPressed(string content)
		{
		}

		public void ToggleInput(bool inputEnabled)
		{
		}
	}
}
