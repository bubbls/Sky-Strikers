using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(2)]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	public class BallTagHandlerDelayBetweenHits : BallTagHandlerBase
	{
		[CompilerGenerated]
		private sealed class _003CGetFlags_003Ed__23 : IEnumerable<BallTag>, IEnumerable, IEnumerator<BallTag>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private BallTag _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public BallTagHandlerDelayBetweenHits _003C_003E4__this;

			private BallTag input;

			public BallTag _003C_003E3__input;

			private IEnumerator _003C_003E7__wrap1;

			BallTag IEnumerator<BallTag>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(BallTag);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetFlags_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<BallTag> IEnumerable<BallTag>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly int _opacityProperty;

		[SerializeField]
		private MeshRenderer _tagVis;

		[SerializeField]
		private float _opacityChangeSpeed;

		private readonly Dictionary<BallTag, float> _tagExpiryDictionary;

		[SerializeField]
		[DefaultForProperty("Tags", 1, 1)]
		private BallTag _Tags;

		private List<BallTag> _tagToRemove;

		private Array _ballTagValues;

		private IEnumerable<BallTag> _cachedFlagsCheck;

		private bool _cachedHasTagChange;

		private bool _shouldShowTagVisual;

		private bool _executeTagVisualUpdate;

		private float _opacity;

		private static Changed<BallTagHandlerDelayBetweenHits> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<BallTagHandlerDelayBetweenHits> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<BallTagHandlerDelayBetweenHits> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(1, 1)]
		[Networked]
		public BallTag Tags
		{
			get
			{
				return default(BallTag);
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void UpdateTagVis()
		{
		}

		public override void TryAddTagFromHit(HittableHitInfo hitInfo)
		{
		}

		public void AddTag(BallTag ballEffectTag, float duration)
		{
		}

		private bool UpdateTags(BallTag ballEffectTag, float duration)
		{
			return false;
		}

		public override bool HasTag(BallTag ballTag)
		{
			return false;
		}

		public override bool CanIgnoreHitSource(HitSourceID hitSourceID)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGetFlags_003Ed__23))]
		private IEnumerable<BallTag> GetFlags(BallTag input)
		{
			return null;
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyTagsUpdated(BallTag tags)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyTagsUpdatedFromHit(BallTag tags, HittableHitInfo hitInfo)
		{
		}

		public override bool IsBallInteractable()
		{
			return false;
		}

		public override void ClearTags()
		{
		}

		private void ToggleTagVisual(bool show)
		{
		}

		private void LateUpdate()
		{
		}

		private void ExecuteTagVisualUpdate(float incr, float target)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyTagsUpdated_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyTagsUpdatedFromHit_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
