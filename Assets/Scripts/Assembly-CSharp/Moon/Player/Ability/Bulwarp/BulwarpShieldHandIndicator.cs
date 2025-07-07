using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpShieldHandIndicator : ProgressIndicator
	{
		[SerializeField]
		private Image[] _fillImages;

		[SerializeField]
		private GameObject _chargeIndicator;

		private bool _isChargeIndicatorExist;

		private bool _isInitialized;

		private void TryInitialize()
		{
		}

		public override void SetProgress(float progress)
		{
		}
	}
}
