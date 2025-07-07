using System;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Interaction;
using Moon.MultiPlay;
using Moon.Player.Visual;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[NetworkBehaviourWeaved(3)]
	[OrderBefore(new Type[] { typeof(MHitter) })]
	[RequireComponent(typeof(NetworkTransform))]
	public class MPlayerHand : NetworkBehaviour
	{
		[Serializable]
		private struct LocalFingerInputData
		{
			public float FingerThumb;

			public float FingerIndex;

			public float FingerOthers;
		}

		[StructLayout((LayoutKind)2, Size = 88)]
		[NetworkStructWeaved(22)]
		private struct HandVisualRelatedData : INetworkStruct
		{
			[FieldOffset(0)]
			public Vector3 PalmRelativePosition;

			[FieldOffset(12)]
			public Quaternion PalmRelativeRotation;

			[FieldOffset(28)]
			public OverlapShapeDescData HandOsdData;
		}

		private const float DefaultHandVelocityMultiplier = 0.7f;

		[SerializeField]
		private bool _isLeftHand;

		[DefaultForProperty("FingerThumb", 0, 1)]
		private float _FingerThumb;

		[DefaultForProperty("FingerIndex", 1, 1)]
		private float _FingerIndex;

		[DefaultForProperty("FingerOthers", 2, 1)]
		private float _FingerOthers;

		[SerializeField]
		private MHitter _mHitter;

		[SerializeField]
		private MGrabInteractor _grabInteractor;

		[SerializeField]
		private Hitbox _hitbox;

		private NetworkTransform _networkTransform;

		private OverlapShapeDescData _handOsdData;

		private PlayerHand _playerHand;

		private PlayerHandInputData _inputData;

		private bool _grabbingEnabled;

		private LocalFingerInputData _localFingerInputData;

		private float _handVelocityMultiplier;

		private IMessageSubscriber _subscriber;

		private static Changed<MPlayerHand> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerHand> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerHand> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public bool IsLeftHand => false;

		[NetworkedWeaved(0, 1)]
		[Networked]
		private float FingerThumb
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NetworkedWeaved(1, 1)]
		[Networked]
		private float FingerIndex
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NetworkedWeaved(2, 1)]
		[Networked]
		private float FingerOthers
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MGrabInteractor GrabInteractor => null;

		public PlayerHand Hand => null;

		private void Awake()
		{
		}

		public void SetPlayerHand(PlayerHand playerHand)
		{
		}

		private Transform GetInteractorAttachPoint()
		{
			return null;
		}

		public void UpdateHandVisualRelatedData(Transform pivot, PlayerSuitHandVisual suitHandVisual)
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void GrabInteractor_OnToggleHandVisualsRequested(bool show)
		{
		}

		private void HandleOnInputFocusChanged(bool hasInputFocus)
		{
		}

		public PlayerHandInputData GetInputData()
		{
			return default(PlayerHandInputData);
		}

		public void UpdateControllerInput(MXRControllerInputData inputData)
		{
		}

		private void ProcessInputActionOnLocal(MXRInputAction inputAction)
		{
		}

		public void UpdatePlayerInput(PlayerInputData playerInputData)
		{
		}

		public override void Render()
		{
		}

		private void HandleFeedback(Vector3 feedbackForce)
		{
		}

		public void ResetVelocityTrackers()
		{
		}

		public Vector3 GetHitterThrowVelocity()
		{
			return default(Vector3);
		}

		public bool IsHoldingGrabbableOfType(IGrabbable targetGrabbable)
		{
			return false;
		}

		public void TryReleaseGrabbableForMatch()
		{
		}

		public void SetHandVelocityMultiplier(float multiplier)
		{
		}

		public void UseDefaultHandVelocityMultiplier()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_UpdateHandVisualRelatedData(HandVisualRelatedData handVisualRelatedData)
		{
		}

		public bool IsMyHitBox(Hitbox hitbox)
		{
			return false;
		}

		public void EnableHitter()
		{
		}

		public void DisableHitter()
		{
		}

		public void EnableGrabbing()
		{
		}

		public void DisableGrabbing()
		{
		}

		public void TemporarilyRemoveHitDetectionLayer(LayerMask layer, float disableTime)
		{
		}

		public void ResetHitterLayers()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 1)]
		protected unsafe static void Rpc_UpdateHandVisualRelatedData_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
