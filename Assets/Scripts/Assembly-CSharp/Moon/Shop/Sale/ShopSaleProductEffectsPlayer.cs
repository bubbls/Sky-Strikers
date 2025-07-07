using UnityEngine;

namespace Moon.Shop.Sale
{
	public class ShopSaleProductEffectsPlayer : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem[] _purchasedEffects;

		[SerializeField]
		private ParticleSystem[] _purchaseCompletedEffects;

		[SerializeField]
		private Animation? _purchasedAnimation;

		[SerializeField]
		private Transform? _purchaseCompleteEffectSpawnPoint;

		private void Awake()
		{
		}

		public void PlayPurchasedEffect()
		{
		}

		public void PlayNewPurchaseCompleteEffects()
		{
		}

		public void StopEffects()
		{
		}
	}
}
