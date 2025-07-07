using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Arena
{
	public class SqueezeBallOnHit : MonoBehaviour
	{
		[SerializeField]
		private MBall _ball;

		[SerializeField]
		private Transform _target;

		[SerializeField]
		private Transform _scalar;

		[SerializeField]
		private Vector3 _scaleDirection;

		[SerializeField]
		private Transform _visualPivot;

		[SerializeField]
		private float _ballSize;

		[SerializeField]
		private BallHitHighlight _hitHighlight;

		[SerializeField]
		private SoundInfo _sfxBallBouncing;

		[SerializeField]
		private SoundInfo _sfxBallBouncingBoundary;

		[SerializeField]
		private SoundInfo _sfxBallRespawn;

		[SerializeField]
		private GameObject _visual;

		[SerializeField]
		private ProjectionOnGround _projectionOnGround;

		[SerializeField]
		private GameObject _fxTrailPrefab;

		[SerializeField]
		private float _trailScale;

		[SerializeField]
		private AudioSource _3dAudioSource;

		private BallTrailFxController _ballTrailFxController;

		private readonly Cooldown _hitFieldCooldown;

		private Vector3 _lastRenderedPosition;

		private Vector3 _targetPunchScale;

		private float _nextHitFxTime;

		private bool _only3dSfx;

		private bool _airWallEnabled;

		public BallTrailFxController BallTrailFxController => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleRender()
		{
		}

		private void UpdateTrail()
		{
		}

		private void UpdateBallSize()
		{
		}

		private void HandleGoalEvent(PlayerInfo lastHitter, ArenaGoal arenaGoal)
		{
		}

		private void HandleDespawned()
		{
		}

		private void ShowVisual(bool show)
		{
		}

		private void HandleSpawned()
		{
		}

		private void HandleOnHit(PlayerInfo lastHitter, Vector3 force, HitSourceID hitSourceID)
		{
		}

		private void HandleOnHitByForce(PlayerInfo playerInfo, Vector3 force, HitSourceID hitSourceID)
		{
		}

		private void HandleOnBallTaggedFromHit(BallTag ballTag, HittableHitInfo hittableHitInfo)
		{
		}

		private void PlayFxOnHit(Vector3 force, PlayerInfo lastHitter, HitSourceID hitSourceID)
		{
		}

		private void SqueezeOnHit(Vector3 force)
		{
		}

		private void HandleOnEnteredCollision(CollisionInfo collisionInfo)
		{
		}

		private void SqueezeOnCollision(Vector3 collisionRelativeVelocity)
		{
		}

		private void ResetHitEffects()
		{
		}
	}
}
