using Chamber8.Framework.Common;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Shop
{
	public class ShopSoundManager : SingleMonoBehaviour<ShopSoundManager, DefaultSingleMonoBehaviourSettings<ShopSoundManager>>
	{
		[SerializeField]
		private SoundInfo _buttonPressSoundInfo;

		[SerializeField]
		private SoundInfo _buttonDisabledSoundInfo;

		[SerializeField]
		private SoundInfo _buttonPopupSoundInfo;

		[SerializeField]
		private SoundInfo _chargingSoundInfo;

		[SerializeField]
		private SoundInfo _openCoverSoundInfo;

		[SerializeField]
		private SoundInfo _closeCoverSoundInfo;

		[SerializeField]
		private SoundInfo _gearRotatingSoundInfo;

		[SerializeField]
		private SoundInfo _screenAlertSoundInfo;

		[SerializeField]
		private SoundInfo _screenLoadingSoundInfo;

		[SerializeField]
		private SoundInfo _screenWarningSoundInfo;

		[SerializeField]
		private SoundInfo _walletGetMoneySoundInfo;

		[SerializeField]
		private SoundInfo _walletIceShakeSoundInfo;

		[SerializeField]
		private SoundInfo _walletLoseMoneySoundInfo;

		[SerializeField]
		private SoundInfo _channelArenaDoorOpenSoundInfo;

		[SerializeField]
		private SoundInfo _channelShopDoorOpenSoundInfo;

		[SerializeField]
		private SoundInfo _skinShelfPurchasedSoundInfo;

		[SerializeField]
		private SoundInfo _skinShelfTryOnSoundInfo;

		private int _gearSoundID;

		private int _loadingSoundID;

		public void PlayButtonPressSound(Vector3 position)
		{
		}

		public void PlayButtonDisabledSound(Vector3 position)
		{
		}

		public void PlayButtonPopupSound(Vector3 position)
		{
		}

		public void PlayChargingSound(Vector3 position)
		{
		}

		public void PlayOpenCoverSound(Vector3 position)
		{
		}

		public void PlayCloseCoverSound(Vector3 position)
		{
		}

		public void PlayGearRotatingSound(Vector3 position)
		{
		}

		public void StopGearRotatingSound()
		{
		}

		public void PlayScreenAlertSound(Vector3 position)
		{
		}

		public int PlayScreenLoadingSound(Vector3 position)
		{
			return 0;
		}

		public void StopScreenLoadingSound()
		{
		}

		public int PlayScreenWarningSound(Vector3 position)
		{
			return 0;
		}

		public void PlayWalletGetMoneySound(Vector3 position)
		{
		}

		public void PlayWalletIceShakeSound(Vector3 position)
		{
		}

		public void PlayWalletLoseMoneySound(Vector3 position)
		{
		}

		public void PlayChannelArenaDoorOpenSound(Vector3 position)
		{
		}

		public void PlayChannelShopDoorOpenSound(Vector3 position)
		{
		}

		public void PlaySkinShelfPurchasedSound(Vector3 position)
		{
		}

		public void PlaySkinShelfTryOnSound(Vector3 position)
		{
		}

		private int PlaySound(SoundInfo soundInfo, Vector3 position)
		{
			return 0;
		}

		public void StopSound(int soundID)
		{
		}
	}
}
