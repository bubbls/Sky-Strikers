using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Player.Pad
{
	[RequireComponent(typeof(UIButton))]
	public class PlayerPadAppIcon : MonoBehaviour
	{
		private UIButton _uiButton;

		public RectTransform RectTransform { get; private set; }

		public event Action<PlayerPadAppIcon> OnIconPressed
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

		public void Initialize()
		{
		}
	}
}
