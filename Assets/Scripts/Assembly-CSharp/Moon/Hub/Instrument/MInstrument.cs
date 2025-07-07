using System;
using System.Collections.Generic;
using System.Diagnostics;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub.Instrument
{
	[NetworkBehaviourWeaved(0)]
	public abstract class MInstrument : NetworkBehaviour
	{
		[SerializeField]
		private int _notPlayCountDownSeconds;

		[SerializeField]
		protected List<InstrumentInteractionItem> _instrumentInteractionItems;

		[SerializeField]
		private List<MeshRenderer> _meshRenderers;

		[SerializeField]
		private MeshRenderer _volumeMeshRenderer;

		[SerializeField]
		private int _maxHitCount;

		private bool _isTrackingPlayTime;

		private DateTime _startTime;

		protected double _playDurationSeconds;

		private Stopwatch _notPlayTimer;

		private Sequence _volumeSequence;

		private const string VolumeMaskRangeID = "_MaskRange";

		private int _hitCount;

		private bool _isTrackingCountHit;

		private Stopwatch _hitCountTimer;

		private const float HitCountPeriodSeconds = 0.3f;

		private bool _hasInteractedForTracking;

		private IMessageSubscriber[] _subscribers;

		private float _lastVolumeValue;

		private static Changed<MInstrument> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MInstrument> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MInstrument> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private int HandleOnSessionStared(IMessage<object> message)
		{
			return 0;
		}

		private int HandleOnSessionEnded(IMessage<object> message)
		{
			return 0;
		}

		private void HandleOnInstrumentInteracted(bool isLeftHand, string id)
		{
		}

		private void MarkInteracted()
		{
		}

		protected virtual bool CustomInteractionInteracted()
		{
			return false;
		}

		protected virtual void TrackingAnalytics()
		{
		}

		private void DoVolumeAnimation(float volumeValue)
		{
		}

		private void KillSequence()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All, TickAligned = false)]
		private void Rpc_PlayInteractItem(string id, PlayerRef playerRef)
		{
		}

		protected virtual HapticImpulse GetHapticImpulse()
		{
			return null;
		}

		private void StartTrackingPlayTime()
		{
		}

		private void CountDownNotPlayTime()
		{
		}

		private void StopTrackingPlayTime()
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

		[NetworkRpcWeavedInvoker(1, 7, 7)]
		[Preserve]
		protected unsafe static void Rpc_PlayInteractItem_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
