using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace Moon.Player.Ability
{
	[NetworkBehaviourWeaved(0)]
	public class MHitterWeapon : NetworkBehaviour
	{
		[SerializeField]
		private MHitter _mHitter;

		[SerializeField]
		private float _velocityMultiplier;

		[SerializeField]
		private PowerUpConsumer _powerUpConsumer;

		private MPlayerHand _mPlayerHand;

		private static Changed<MHitterWeapon> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHitterWeapon> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHitterWeapon> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public MHitter MHitter => null;

		public MPlayerHand MPlayerHand => null;

		public event Action<bool> OnHitDetectionToggled
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

		public void Initialize(MPlayer player, MPlayerHand playerHand)
		{
		}

		public void ResetHitterWeapon()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void UpdateHitterVelocityTracker(int tick, Vector3 handVelocity, Vector3 playerVelocity)
		{
		}

		public void ToggleWeapon(bool enable)
		{
		}

		private void HandleFeedback(Vector3 feedbackForce)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
