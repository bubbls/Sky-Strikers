using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	[NetworkBehaviourWeaved(15)]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	public class NetworkExtrapolator : NetworkBehaviour, IBeforeUpdate
	{
		public float forceUpdateDistanceThreshold;

		public float forceResetDistanceThreshold;

		public float forceUpdateAngleThreshold;

		public float forceResetAngleThreshold;

		public float forceUpdateDistanceError;

		public float forceUpdateRotationError;

		public bool isPredicted;

		[SerializeField]
		private Transform _targetTransform;

		[SerializeField]
		private Rigidbody _targetRigidbody;

		[SerializeField]
		[DefaultForProperty("Data", 0, 15)]
		private NetworkExtrapolationData _Data;

		private ConstantForce _constantForce;

		private RawInterpolator _dataInterpolator;

		private float _fixedDeltaTime;

		private Vector3 _targetPos;

		private Quaternion _targetRot;

		private float _targetSpeed;

		private float _targetAnglerSpeed;

		private bool _forceUpdatePosition;

		private bool _forceUpdateRotation;

		private bool _wasRenderedThisUpdate;

		private bool? _hasFirstDataFrame;

		private static Changed<NetworkExtrapolator> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<NetworkExtrapolator> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<NetworkExtrapolator> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 15)]
		public NetworkExtrapolationData Data
		{
			get
			{
				return default(NetworkExtrapolationData);
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

		public void SetInitialPosition(Vector3 position)
		{
		}

		private void RecordNetworkData()
		{
		}

		public void BeforeUpdate()
		{
		}

		public override void Render()
		{
		}

		private void Update()
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
