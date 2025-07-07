using Chamber8.Framework.Messaging;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class LocalPlayerSpeedLines : MonoBehaviour
	{
		private static readonly int _rangeOffset;

		[SerializeField]
		private AnimationCurve _animationCurve;

		[SerializeField]
		private MeshRenderer _speedLineMesh;

		[SerializeField]
		private float _fillChangeIncreaseSpeed;

		[SerializeField]
		private float _fillChangeDecreaseSpeed;

		[SerializeField]
		private float _turnSimulatedVelocity;

		[SerializeField]
		private float _turnSimulatedVelocityDecreaseSpeed;

		private float _curTurningMagnitude;

		private Rigidbody _trackedRigidbody;

		private float _velocityMagnitude;

		private float _targetSpeedFill;

		private float _speedFill;

		private bool _speedLinesEnabled;

		private IMessageSubscriber _messageSubscriber;

		private void Start()
		{
		}

		private void LocalPlayerSharedData_OnActiveCameraChanged(Camera _, GameCameraType cameraType)
		{
		}

		private void ListenForTurnEvents()
		{
		}

		private void OnDestroy()
		{
		}

		private void GameOption_OnOptionsSaved(GameOption.Options options)
		{
		}

		private void LateUpdate()
		{
		}

		private void ToggleMesh(bool show)
		{
		}

		private int HandlePlayerLocomotionMessage(IMessage<PlayerLocomotionMessage> message)
		{
			return 0;
		}
	}
}
