using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Utils;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Ability
{
	[NetworkBehaviourWeaved(0)]
	public class MPlayerAbilityWeaponManager : NetworkBehaviour, ICommandExecutor
	{
		[SerializeField]
		private MXRInputAction _equipWeaponAction;

		[SerializeField]
		private MXRInputAction _unequipWeaponAction;

		[SerializeField]
		protected MWeaponController _leftHandWeaponController;

		[SerializeField]
		protected MWeaponController _rightHandWeaponController;

		private PlayerAbilityWeaponInputData _abilityWeaponInputData;

		private static Changed<MPlayerAbilityWeaponManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerAbilityWeaponManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerAbilityWeaponManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		private MPlayer Player => null;

		public bool IsInitialized { get; private set; }

		public event Action<MWeaponController, bool> OnHoldingWeaponChanged
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

		public event Action OnInitialize
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

		public event Action OnReset
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

		public void ResetWeaponManager()
		{
		}

		protected virtual void HandleWeaponManagerReset()
		{
		}

		public void UpdateInput(PlayerInputData inputData)
		{
		}

		public PlayerAbilityWeaponInputData GetInputData()
		{
			return default(PlayerAbilityWeaponInputData);
		}

		public bool IsHoldingWeaponLocally(bool isLeftHand)
		{
			return false;
		}

		public void HandleOnSuitVisualsChanged()
		{
		}

		private void WeaponController_OnIsHoldingWeaponChanged(MWeaponController controller, bool isHoldingWeapon)
		{
		}

		private void ExecuteHoldingWeaponChanged()
		{
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
