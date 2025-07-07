using Fusion;
using TMPro;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(25)]
	public class BallTagHandlerHitLimited : BallTagHandlerBase
	{
		private static readonly int _opacityProperty;

		[SerializeField]
		private MeshRenderer _tagVis;

		[DefaultForProperty("HitCount", 1, 1)]
		[SerializeField]
		private int _HitCount;

		[DefaultForProperty("LastHitInfo", 2, 22)]
		[SerializeField]
		private HittableHitInfo _LastHitInfo;

		[DefaultForProperty("LastHitTeam", 24, 1)]
		[SerializeField]
		private TeamNo _LastHitTeam;

		[SerializeField]
		private TMP_Text _hitCountText;

		private bool _cachedHasTagChange;

		private int _localHitCount;

		private static Changed<BallTagHandlerHitLimited> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<BallTagHandlerHitLimited> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<BallTagHandlerHitLimited> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(1, 1)]
		[Networked]
		public int HitCount
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 22)]
		public HittableHitInfo LastHitInfo
		{
			get
			{
				return default(HittableHitInfo);
			}
			private set
			{
			}
		}

		[NetworkedWeaved(24, 1)]
		[Networked]
		public TeamNo LastHitTeam
		{
			get
			{
				return default(TeamNo);
			}
			private set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void TryAddTagFromHit(HittableHitInfo hitInfo)
		{
		}

		public override bool HasTag(BallTag ballTag)
		{
			return false;
		}

		public override bool CanIgnoreHitSource(HitSourceID hitSourceID)
		{
			return false;
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyTagsUpdatedFromHit(int hitCount, HittableHitInfo lastHitInfo)
		{
		}

		public override bool IsBallInteractable()
		{
			return false;
		}

		public override void ClearTags()
		{
		}

		protected override void OnActiveStateChanged(bool isActive)
		{
		}

		private void ToggleTagVisual(bool show)
		{
		}

		private void ExecuteTagVisualUpdate(float target)
		{
		}

		private void ToggleHitCountNumber(bool show)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 1, 7)]
		protected unsafe static void Rpc_NotifyTagsUpdatedFromHit_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
