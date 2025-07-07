using System;
using System.Collections.Generic;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamAbilityFx : MonoBehaviour, IDisposable
	{
		[SerializeField]
		private HapticImpulse _suckingHapticImpulse;

		[SerializeField]
		private HapticImpulse _blastHapticImpulse;

		[SerializeField]
		private HapticImpulse _blastHapticImpulseNoAmmo;

		private readonly Dictionary<MPlayerHand, JetstreamWeaponVisual> _playerMakerWeaponVisuals;

		private MPlayer _player;

		private bool _playedBestShotRangeFx;

		public void Initialize(MPlayer player)
		{
		}

		public void Dispose()
		{
		}

		private void PlayerVisualsController_OnHeldWeaponVisualChanged(Transform pivot, PlayerSuitWeaponVisual suitWeaponVisual, bool isLeft)
		{
		}

		private void UpdateWeaponVisualReferences(params MPlayerHand[] mPlayerHands)
		{
		}

		public void HandleSuckingHaptics(bool isLeftHand)
		{
		}

		public void ToggleEffectsOnBall(MPlayerHand hand, MBall ball)
		{
		}

		public void ResetFxs()
		{
		}

		public void HandleBallBlastAreaStatusChanged(MPlayerHand hand, bool isInBlastArea)
		{
		}

		public void PlayBlastFx(MPlayerHand hand, SuitWeaponVisualTheme theme, bool usedAmmo, bool isLastAmmo)
		{
		}

		public void PlayBlastFailedFx(SuitWeaponVisualTheme theme, Vector3 blastPosition)
		{
		}

		public void EnterBallShotState(MPlayerHand hand, MBall networkedBall, float ballControlDuration)
		{
		}

		public void AnimateSuckingRange(MPlayerHand hand, float t)
		{
		}

		public void TryShowBestShotVisuals(MBall ball, MPlayerHand trackedHand, bool isInBestShotRange)
		{
		}

		public void PlayBallShotFromBestRangeFx(MPlayerHand hand)
		{
		}
	}
}
