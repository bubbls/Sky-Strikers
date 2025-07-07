using System.Collections.Generic;
using System.Runtime.InteropServices;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(4)]
	public class BallModifierHeatSeekerHandler : BallModifierHandlerBase
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[NetworkStructWeaved(4)]
		private struct HeatSeekerNetworkInfo : INetworkStruct
		{
			[FieldOffset(0)]
			public TeamNo HitTeamNo;

			[FieldOffset(4)]
			public Vector3 ArenaGoalPosition;
		}

		[SerializeField]
		private float _heatSeekerForce;

		[SerializeField]
		private float _heatSeekerBallMinSpeed;

		[SerializeField]
		private int _heatSeekerMaxHitCount;

		[SerializeField]
		private float _heatSeekerSpeedIncreaseByHit;

		[SerializeField]
		private Transform _visual;

		[SerializeField]
		private MeshRenderer _heatSeekerMeshRenderer;

		[SerializeField]
		private ParticleSystem _ballTrailBlue;

		[SerializeField]
		private ParticleSystem _ballTrailRed;

		[DefaultForProperty("HeatSeekerData", 0, 4)]
		private HeatSeekerNetworkInfo _HeatSeekerData;

		private HittableHitInfo _cachedHittableHitInfo;

		private readonly Dictionary<TeamNo, List<ArenaGoal>> _teamGoals;

		private PlayerRef _currentHitPlayerRef;

		private HitSourceID _currentHitSourceID;

		private readonly string _heatSeekerMaterialTeamProperty;

		private bool _canHitTheBall;

		private Vector3 _heatSeekerBallVelocity;

		private Vector3 _heatSeekerBallForce;

		private Vector3 _heatSeekerVisualTargetDirection;

		private Quaternion _heatSeekerVisualTargetRotation;

		private int _currentHitCount;

		private float _currentBallSpeed;

		private static Changed<BallModifierHeatSeekerHandler> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<BallModifierHeatSeekerHandler> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<BallModifierHeatSeekerHandler> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 4)]
		[Networked]
		private HeatSeekerNetworkInfo HeatSeekerData
		{
			get
			{
				return default(HeatSeekerNetworkInfo);
			}
			set
			{
			}
		}

		protected override void HandleOnRegisterEvents()
		{
		}

		protected override void HandleOnUnregisterEvents()
		{
		}

		private void MBall_HandleOnSpawned()
		{
		}

		private void MBall_HandleOnGoalEvent(PlayerInfo playerInfo, ArenaGoal arenaGoal)
		{
		}

		protected override void HandleOnDespawned()
		{
		}

		private void Reset()
		{
		}

		private void SetupGoals()
		{
		}

		private void MBall_HandleOnHit(PlayerInfo hitPlayerInfo, Vector3 position, HitSourceID hitSourceID)
		{
		}

		private Transform TryGetTargetArenaGoal(TeamNo teamNo)
		{
			return null;
		}

		protected override void HandleOnSetup()
		{
		}

		private void ToggleVisuals(bool enable, TeamNo teamNo)
		{
		}

		private void SetUpTrailFX(bool enable, TeamNo teamNo, ParticleSystem trailFX, TeamNo targetTeamNo)
		{
		}

		public override void HandleFixedUpdateNetwork()
		{
		}

		public override void HandleRender()
		{
		}

		private float CalculateBallSpeed(int hitCount)
		{
			return 0f;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
