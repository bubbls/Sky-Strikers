using UnityEngine;

namespace Moon
{
	public class DefaultPlayerAmmoIndicator : PlayerAmmoIndicator
	{
		[SerializeField]
		private GameObject[] _indicators;

		public override void SetAmmo(int targetAmount)
		{
		}
	}
}
