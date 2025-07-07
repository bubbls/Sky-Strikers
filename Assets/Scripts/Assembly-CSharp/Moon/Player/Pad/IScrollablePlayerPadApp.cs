using System;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public interface IScrollablePlayerPadApp
	{
		ScrollRect ScrollRect { get; }

		event Action<ScrollRect> OnRequestRegisterScrollRect;

		event Action<ScrollRect> OnRequestUnRegisterScrollRect;
	}
}
