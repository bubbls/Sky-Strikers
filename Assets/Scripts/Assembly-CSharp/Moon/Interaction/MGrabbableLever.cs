using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace Moon.Interaction
{
	[NetworkBehaviourWeaved(1)]
	public class MGrabbableLever : MGrabbable
	{
		[SerializeField]
		private OrthoProjPlane _leverMovingPlane;

		[SerializeField]
		private AttractingPositions _leverMovingAttractingPositions;

		[SerializeField]
		private Transform _leverPositionOnMovingPlane;

		[SerializeField]
		private List<Transform> _leverStayPositions;

		private Transform _closestKnot;

		private int _snappedIndex;

		private static Changed<MGrabbableLever> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbableLever> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbableLever> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public int SnappedIndex
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public Transform SnappedTransform => null;

		public event Action OnSnappedIndexChanged
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

		public override void FixedUpdateNetwork()
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
		{
		}

		public void SnapToClosest()
		{
		}

		public void SnapTo(Transform knot)
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
