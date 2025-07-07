using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using Fusion.LagCompensation;
using Moon.AI.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[NetworkBehaviourWeaved(7)]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	[OrderAfter(new Type[] { typeof(HitboxManager) })]
	public class MHitter : NetworkBehaviour
	{
		[SerializeField]
		private LayerMask _layerMask;

		[SerializeField]
		private HitSourceID _hitSourceID;

		[SerializeField]
		private OverlapShapeDesc _overlapShapeDesc;

		[SerializeField]
		private MHitterDebugger _hitterDebugger;

		[SerializeField]
		private bool _hitDetectionEnabled;

		private LayerMask _activeHitDetectionLayer;

		private Dictionary<int, float> _tempDisabledLayers;

		[DefaultForProperty("UpdateThrowVelocityTick", 0, 1)]
		private Tick _UpdateThrowVelocityTick;

		[DefaultForProperty("ThrowVelocity", 1, 3)]
		private Vector3 _ThrowVelocity;

		[DefaultForProperty("BodyVelocity", 4, 3)]
		private Vector3 _BodyVelocity;

		private HashSet<Hitbox> _hitboxes;

		private List<LagCompensatedHit> _cachedHits;

		private int _cachedHitCount;

		private HashSet<Hitbox> _cachedHitsHashset;

		private Query _query;

		private HittableHitInfo _hitInfo;

		private Hittable _cachedHittable;

		private readonly List<int> _disabledLayersToReset;

		private static Changed<MHitter> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHitter> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHitter> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
		private Tick UpdateThrowVelocityTick
		{
			get
			{
				return default(Tick);
			}
			set
			{
			}
		}

		[NetworkedWeaved(1, 3)]
		[Networked(OnChanged = "HandleThrowVelocityUpdated")]
		private Vector3 ThrowVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[NetworkedWeaved(4, 3)]
		[Networked]
		private Vector3 BodyVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public int LastUpdatedTick { get; private set; }

		public event Action<Hittable> OnHit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<Vector3> OnFeedback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void Spawned()
		{
		}

		public void ToggleHitDetection(bool enable)
		{
		}

		public void UpdateThrowVelocity(int tick, Vector3 throwVelocity)
		{
		}

		public void UpdateBodyVelocity(Vector3 bodyVelocity)
		{
		}

		public void SetOverlapShapeDescData(Transform space, OverlapShapeDescData osdData)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void CheckHitWithLagCompensation()
		{
		}

		public void RaiseFeedback(Vector3 feedbackForce)
		{
		}

		public int GetTick()
		{
			return 0;
		}

		public Vector3 GetThrowVelocity()
		{
			return default(Vector3);
		}

		public Vector3 GetHitterBodyVelocity()
		{
			return default(Vector3);
		}

		[Preserve]
		private static void HandleThrowVelocityUpdated(Changed<MHitter> changed)
		{
		}

		private void UpdateHitDetectionLayers()
		{
		}

		public void RemoveLayerFromHitDetection(LayerMask layer, float disableTime)
		{
		}

		public void ResetHitDetectionLayers()
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
