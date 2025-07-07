using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.MultiPlay;

namespace Moon.Player.Ability
{
	[OrderAfter(new Type[]
	{
		typeof(MPlayerContainer),
		typeof(MPlayer)
	})]
	[NetworkBehaviourWeaved(0)]
	public abstract class MPlayerAbility : NetworkBehaviour
	{
		private IMessageSubscriber[] _subscribers;

		private static Changed<MPlayerAbility> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerAbility> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerAbility> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected MPlayer Player => null;

		private MPlayerContainer PlayerContainer => null;

		protected LocalPlayerRig LocalPlayerRig { get; private set; }

		protected HashSet<MPlayerHand> HandsPressingTrigger { get; }

		protected HashSet<MPlayerHand> HandsPressingGrab { get; }

		protected PlayerInputData LatestInputData { get; private set; }

		protected bool IsInitialized { get; private set; }

		public override void Spawned()
		{
		}

		private void ListenToSpawnMessages()
		{
		}

		private bool IsContainerAndPlayerValid(MPlayerContainer playerContainer, MPlayer player)
		{
			return false;
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void CompleteSpawn()
		{
		}

		private void ResetAbility(bool revertPlayerChanges)
		{
		}

		private int HandleMPlayerContainerSpawnedMessage(IMessage<MPlayerContainer> message)
		{
			return 0;
		}

		private int HandleMPlayerSpawnedMessage(IMessage<MPlayer> message)
		{
			return 0;
		}

		protected abstract void HandleOnSpawned();

		protected abstract void HandleResetAbility();

		public void ProcessInput(PlayerInputData inputData, MPlayerHand leftHand, MPlayerHand rightHand)
		{
		}

		public virtual PlayerAbilityWeaponInputData GetInputData()
		{
			return default(PlayerAbilityWeaponInputData);
		}

		protected virtual void OnPreProcessInput(PlayerInputData inputData)
		{
		}

		private void ProcessHand(MXRInputAction inputAction, MPlayerHand mPlayerHand)
		{
		}

		protected virtual void OnTriggerPressed(MPlayerHand mPlayerHand)
		{
		}

		protected virtual void OnTriggerHold(MPlayerHand mPlayerHand)
		{
		}

		protected virtual void OnTriggerReleased(MPlayerHand mPlayerHand)
		{
		}

		protected virtual void OnGrabPressed(MPlayerHand mPlayerHand)
		{
		}

		protected virtual void OnGrabHold(MPlayerHand mPlayerHand)
		{
		}

		protected virtual void OnGrabReleased(MPlayerHand mPlayerHand)
		{
		}

		public void NotifyPlayerInfoUpdated(PlayerInfo playerInfo)
		{
		}

		private void PlayerVisualsController_OnSuitChanged()
		{
		}

		protected virtual void HandleOnPlayerInfoUpdated(PlayerInfo playerInfo)
		{
		}

		protected virtual void HandleOnPlayerSuitVisualsUpdated(PlayerInfo playerInfo)
		{
		}

		private void RevertMPlayerChanges()
		{
		}

		protected void RevertLocalPlayerRigChanges()
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
