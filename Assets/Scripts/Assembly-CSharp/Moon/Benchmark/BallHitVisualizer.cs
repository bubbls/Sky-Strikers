using Chamber8.Framework.Messaging;
using Moon.Arena;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon.Benchmark
{
	public class BallHitVisualizer : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer _hitProjection;

		[SerializeField]
		private Transform _ballVisual;

		[SerializeField]
		private Transform _hitIndicator;

		[SerializeField]
		private LayerMask _projectionLayerMasks;

		[SerializeField]
		private InputActionReference _recenterBallAction;

		[SerializeField]
		private bool _enable;

		private IMessageSubscriber _playerActionsMessageSubscription;

		private IMessageSubscriber _playerActionsBenchmarkMessageSubscription;

		private MBall _targetBall;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void HandleOnRecenterBallActionPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void OnDestroy()
		{
		}

		private int HandlePlayerAction(IMessage<PlayerActionMessage> message)
		{
			return 0;
		}

		private int HandleBenchmarkMessage(IMessage<PlayerActionMessage> message)
		{
			return 0;
		}

		private void ShowHitPoint(BallHittableInfoMessageData hittableInfoMessageData)
		{
		}

		private void UpdateProjection(BallHittableInfoMessageData hittableInfoMessageData)
		{
		}

		private void UpdateInfoForBallHitWithBat(BallHitBenchmarkMessageData benchmarkMessageData)
		{
		}

		private void UpdateInfoForBallHitWithRocket(BallHittableInfoMessageData hittableInfoMessageData)
		{
		}

		private void UpdateHitForceInfo(Vector3 appliedForce)
		{
		}
	}
}
