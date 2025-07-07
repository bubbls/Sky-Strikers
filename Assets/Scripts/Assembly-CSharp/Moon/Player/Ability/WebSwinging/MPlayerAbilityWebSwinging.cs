using System;
using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Ability.WebSwinging
{
	[NetworkBehaviourWeaved(0)]
	public class MPlayerAbilityWebSwinging : MPlayerAbility
	{
		[Serializable]
		public class WebShootingConfig
		{
			public float WebShootRange;

			public float WebShootSpeed;

			public float JointSpring;

			public float JointDamper;

			public float JointMassScale;

			public float JointMinDistanceModifer;

			public float JointMaxDistanceModifer;

			public GameObject WebLinePrefab;

			public AnimationCurve PullForceCurve;

			public float PullForce;

			public float PullForceY;

			public float PullThreshold;

			public float MaxPlayerSwingVelocity;

			public AnimationCurve SwingHapticCurve;

			public float SwingHapticDuration;

			public float SwingHapticAmp;

			public float SwingHapticFrequency;

			public float SwingHapticDistance;

			public AnimationCurve PullHapticCurve;

			public float PullHapticDuration;

			public float PullHapticAmp;

			public float PullHapticFrequency;
		}

		[SerializeField]
		[Space(10f)]
		private WebShootingConfig _webShootingConfig;

		[SerializeField]
		private GameObject _leftTargetingIndicator;

		[SerializeField]
		private GameObject _rightTargetingIndicator;

		[SerializeField]
		private float _swingingGravityY;

		[SerializeField]
		private GameObject _wind;

		private LocalPlayerRig _localPlayerRig;

		private Vector3 _direction;

		private Vector3 _forceDirection;

		private AddConstantForce _localPlayerAddConstantForce;

		private WebSwingingHandHandler _leftHandHandler;

		private WebSwingingHandHandler _rightHandHandler;

		private Vector3 _lastPlayerPosition;

		private Vector3 _currentPlayerPosition;

		private static Changed<MPlayerAbilityWebSwinging> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerAbilityWebSwinging> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerAbilityWebSwinging> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnSpawned()
		{
		}

		protected override void HandleResetAbility()
		{
		}

		private void WebSwingingHandHandler_OnWebAttachedToSurface()
		{
		}

		private void WebSwingingHandHandler_OnWebReleased()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		protected override void OnTriggerPressed(MPlayerHand mPlayerHand)
		{
		}

		protected override void OnTriggerHold(MPlayerHand mPlayerHand)
		{
		}

		protected override void OnTriggerReleased(MPlayerHand mPlayerHand)
		{
		}

		private void Reset()
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
