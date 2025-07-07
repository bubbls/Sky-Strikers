using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(1)]
	public abstract class BallTagHandlerBase : NetworkBehaviour, IBallTagQuery
	{
		[SerializeField]
		[DefaultForProperty("IsActive", 0, 1)]
		private NetworkBool _IsActive;

		[SerializeField]
		private Material _taggingMaterial;

		private static Changed<BallTagHandlerBase> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<BallTagHandlerBase> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<BallTagHandlerBase> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
		public NetworkBool IsActive
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		public Material TaggingMaterial => null;

		public event Action<BallTag, HittableHitInfo> OnBallTaggedFromHit
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

		public void ToggleActive(bool isActive)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		protected virtual void OnActiveStateChanged(bool isActive)
		{
		}

		public abstract void TryAddTagFromHit(HittableHitInfo hitInfo);

		public abstract void ClearTags();

		public abstract bool HasTag(BallTag ballTag);

		public abstract bool CanIgnoreHitSource(HitSourceID hitSourceID);

		public abstract bool IsBallInteractable();

		protected void RaiseOnBallTaggedFromHit(BallTag tags, HittableHitInfo hitInfo)
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
