using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Hub;
using Moon.LIV;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Player.Ability.Observer
{
	[NetworkBehaviourWeaved(0)]
	public class MPlayerAbilityObserver : MPlayerAbility
	{
		[SerializeField]
		private PlayerLocomotionConfiguration _locomotionConfiguration;

		[SerializeField]
		private ObserverLocomotionPlugin _observerLocomotionPlugin;

		[SerializeField]
		private float _minLivCameraInteractionDistance;

		[SerializeField]
		private float _minLivCameraFacingAngleForInteraction;

		private ObserverSuitHandVisual _observerSuitHandVisual;

		private IMessageSubscriber _messageSubscriber;

		private bool _rayCheckEnabled;

		private Ray _cachedRay;

		private RaycastHit _cachedHit;

		private ManualButton _cachedManualButton;

		private UIButton _cachedUIButton;

		private LIVButton _cachedLivButton;

		private LIVIncreaseDecreaseButton _cachedLivIncreaseDecreaseButton;

		private Vector3 _livCameraPosition;

		private Vector3 _playerHeadPosition;

		private float _playerFacingAngleToLivCamera;

		private int _cachedHitCount;

		private float _cachedDistance;

		private bool _cachedDidHitPadInteractable;

		private bool _cachedDidHitButton;

		private bool _isNearLivCamera;

		private Vector3 _lastPadInteractableHitPoint;

		private static Changed<MPlayerAbilityObserver> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerAbilityObserver> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerAbilityObserver> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnSpawned()
		{
		}

		protected override void HandleResetAbility()
		{
		}

		private void TryGetObserverSuitHandVisual(PlayerVisualsController playerVisualsController)
		{
		}

		public override void Render()
		{
		}

		private int HandleGeneralMessage(IMessage<GeneralMessage> arg)
		{
			return 0;
		}

		private void TryToggleRayCheck(bool enable)
		{
		}

		protected override void OnTriggerPressed(MPlayerHand mPlayerHand)
		{
		}

		private void TryCheckForPadInteractable()
		{
		}

		private bool CheckForLivButton()
		{
			return false;
		}

		private void ClearLivButtons()
		{
		}

		private void TryPressLivButtons()
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
