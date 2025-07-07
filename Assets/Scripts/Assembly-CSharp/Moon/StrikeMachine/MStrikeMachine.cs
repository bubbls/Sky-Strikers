using System;
using DP.Takeaway.Runtime;
using DP.Takeaway.Sound;
using Fusion;
using Moon.Arena;
using TMPro;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.StrikeMachine
{
	[NetworkBehaviourWeaved(5)]
	[OrderAfter(new Type[] { typeof(NetworkRigidbody) })]
	public class MStrikeMachine : NetworkBehaviour, IAddExtraForceFromHit
	{
		public enum SFX
		{
			BatHitBall = 0,
			BallSpin = 1,
			BallCollide = 2,
			ScoreStart = 3,
			ScoreEnd = 4,
			Scoring = 5,
			NewMaxScore = 6,
			ScoringPoint = 7
		}

		public enum VFX
		{
			BatHitBall = 0,
			BallCollide = 1,
			NewMaxScore = 2,
			ScoringPoint = 3
		}

		public enum BallState
		{
			None = 0,
			Active = 1
		}

		[Serializable]
		private class VFXInfo
		{
			public GameObject GO;

			public float Duration;
		}

		[Serializable]
		private class VFXLookup : DP.Takeaway.Runtime.SerializableDictionary<VFX, VFXInfo>
		{
		}

		[Serializable]
		private class SFXLookup : DP.Takeaway.Runtime.SerializableDictionary<SFX, SoundInfo>
		{
		}

		[SerializeField]
		private HitType _supportedHitType;

		[SerializeField]
		private float _maxAddSpeed;

		[SerializeField]
		private float _activeSpeed;

		[SerializeField]
		private float _hitMultiplier;

		[SerializeField]
		private Rigidbody _rigidBody;

		[SerializeField]
		private HingeJoint _joint;

		[SerializeField]
		private TextMeshPro _scoreText;

		[SerializeField]
		private TextMeshProCircle _maxScoreText;

		[SerializeField]
		private TextMeshPro _speedText;

		[SerializeField]
		private VFXLookup _effects;

		[SerializeField]
		private SFXLookup _sounds;

		[SerializeField]
		private AudioSource _audioSource;

		[SerializeField]
		private HoloRenderer _holoRenderer;

		[SerializeField]
		private Color _holoDefaultColor;

		[SerializeField]
		private Color _holoActiveColor;

		[SerializeField]
		private Color _ballDefaultColor;

		[SerializeField]
		private Color _ballActiveColor;

		[SerializeField]
		private Color _holoOverlapColor;

		[SerializeField]
		private Vector3 _holoOverlapScale;

		[SerializeField]
		private AnimationCurve _holoOverlapCurve;

		[SerializeField]
		[Range(0f, 1f)]
		private float _holoOverlapRange;

		[SerializeField]
		private Vector3 _holoSpectrumScale;

		[SerializeField]
		private Renderer[] _ballRenderers;

		private int _scoringSoundId;

		private Vector3 _holoPosition;

		private float[] _bgmSpectrum;

		[DefaultForProperty("Struct", 0, 1)]
		private NetworkBool _Struct;

		[DefaultForProperty("State", 1, 1)]
		[SerializeField]
		private BallState _State;

		[SerializeField]
		[DefaultForProperty("Score", 2, 1)]
		private int _Score;

		[DefaultForProperty("MaxScore", 3, 1)]
		[SerializeField]
		private int _MaxScore;

		[DefaultForProperty("Speed", 4, 1)]
		[SerializeField]
		private float _Speed;

		private static Changed<MStrikeMachine> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MStrikeMachine> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MStrikeMachine> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public HitType SupportedHitType => default(HitType);

		[NetworkedWeaved(0, 1)]
		[Networked]
		private NetworkBool Struct
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[Networked(OnChanged = "OnNetworkStateChange")]
		[NetworkedWeaved(1, 1)]
		public BallState State
		{
			get
			{
				return default(BallState);
			}
			private set
			{
			}
		}

		[NetworkedWeaved(2, 1)]
		[Networked(OnChanged = "OnNetworkScoreChange")]
		public int Score
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		[Networked(OnChanged = "OnNetworkMaxScoreChanged")]
		[NetworkedWeaved(3, 1)]
		public int MaxScore
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		[Networked(OnChanged = "OnNetworkSpeedChanged")]
		[NetworkedWeaved(4, 1)]
		public float Speed
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void UpdateState()
		{
		}

		private void SetState(BallState state)
		{
		}

		private void UpdateBallColor()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		public void RPC_AddForce(Vector3 force, ForceMode forceMode)
		{
		}

		[Preserve]
		private static void OnNetworkStateChange(Changed<MStrikeMachine> changed)
		{
		}

		[Preserve]
		private static void OnNetworkScoreChange(Changed<MStrikeMachine> changed)
		{
		}

		[Preserve]
		private static void OnNetworkMaxScoreChanged(Changed<MStrikeMachine> changed)
		{
		}

		[Preserve]
		private static void OnNetworkSpeedChanged(Changed<MStrikeMachine> changed)
		{
		}

		public void SetRigidbody(Rigidbody rb)
		{
		}

		public void AddForce(Vector3 targetForce, ForceMode forceMode, HittableHitInfo hitInfo)
		{
		}

		private void AddVelocity(Vector3 velocity)
		{
		}

		private void HandleOnHit(MHitter hitter, HittableHitInfo hitInfo)
		{
		}

		private void HandleOnTriggerFirstEnter(GameObject from)
		{
		}

		private int Speed2Score(float speed)
		{
			return 0;
		}

		private int PlaySound(SFX soundName, Vector3 position)
		{
			return 0;
		}

		private void PlaySound(SFX soundName, AudioSource source)
		{
		}

		private void StopSound(int id)
		{
		}

		private void StopAllSound()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		public void Rpc_PlayEffect(VFX effectName, Vector3 position)
		{
		}

		public void PlayEffect(VFX effectName, Vector3 position)
		{
		}

		public override void Render()
		{
		}

		private void SampleAudioSource()
		{
		}

		private void OnHoloRendererUpdate(int index, Matrix4x4 matrix, out Color color, out Vector3 scale)
		{
			color = default(Color);
			scale = default(Vector3);
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 1)]
		protected unsafe static void RPC_AddForce_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 1, 7)]
		protected unsafe static void Rpc_PlayEffect_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
