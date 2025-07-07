using UnityEngine;

namespace Moon.Player.Pad
{
	public abstract class NotificationPadCurrencyInfoBase : MonoBehaviour
	{
		public abstract void SetBalance(int balance, int change);
	}
}
