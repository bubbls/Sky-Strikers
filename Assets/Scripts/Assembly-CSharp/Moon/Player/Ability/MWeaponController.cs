using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability
{
	[NetworkBehaviourWeaved(1)]
	[OrderAfter(new Type[] { typeof(MNetworkRig) })]
	[RequireComponent(typeof(PlayerHoldableWeapon))]
	public abstract class MWeaponController : NetworkBehaviour
	{
		[DefaultForProperty("IsHoldingItemToggle", 0, 1)]
		private int _IsHoldingItemToggle;

		[SerializeField]
		private bool _isLeftHandWeaponController;

		private static Changed<MWeaponController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MWeaponController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MWeaponController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected MPlayer Player => null;

		[NetworkedWeaved(0, 1)]
		[Networked(OnChanged = "OnIsHoldingItemChanged")]
		private int IsHoldingItemToggle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsHoldingWeapon
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool IsHoldingWeaponLocally { get; private set; }

		protected PlayerHoldableWeapon PlayerHoldable { get; private set; }

		protected bool IsInitialized { get; private set; }

		public MPlayerHand TargetMPlayerHand { get; private set; }

		protected NetworkTransform HandNetworkTransform { get; private set; }

		protected bool IsLeftHandWeaponController => false;

		public event Action<MWeaponController, bool> OnIsHoldingWeaponChanged
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

		protected abstract void HandleOnInitialize();

		public void ResetWeaponController()
		{
		}

		protected abstract void HandleResetWeaponController();

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		protected virtual void FollowTransform(Transform trans)
		{
		}

		public virtual void CollectInputData(ref PlayerAbilityWeaponInputData data)
		{
		}

		public override void Render()
		{
		}

		public virtual void UpdateInput(PlayerInputData playerInputData)
		{
		}

		public void ToggleHeldWeapon(bool showWeapon, bool checkForward = true)
		{
		}

		[Preserve]
		private static void OnIsHoldingItemChanged(Changed<MWeaponController> changed)
		{
		}

		protected virtual void ProcessToggleHeldWeapon()
		{
		}

		private void NotifyIsHoldingWeaponChanged(bool isHoldingWeapon)
		{
		}

		public void HandleOnSuitVisualsChanged()
		{
		}

		protected abstract void TrySetupVisualsOnHand(PlayerHand playerHand);

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
