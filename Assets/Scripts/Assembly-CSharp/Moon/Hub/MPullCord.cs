using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Interaction;
using UnityEngine;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(1)]
	public class MPullCord : MGrabbable
	{
		[SerializeField]
		private float _startDistance;

		[SerializeField]
		private Transform _startPoint;

		[SerializeField]
		private Transform _endPoint;

		private static Changed<MPullCord> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPullCord> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPullCord> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public bool IsReachedStartDistance => false;

		public bool EverReachedStartDistance { get; private set; }

		public event Action OnGrabbing
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

		public override void Render()
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
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
