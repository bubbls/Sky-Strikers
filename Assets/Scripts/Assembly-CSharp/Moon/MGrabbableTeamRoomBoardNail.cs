using Fusion;
using Moon.Interaction;
using UnityEngine;

namespace Moon
{
	[NetworkBehaviourWeaved(1)]
	public class MGrabbableTeamRoomBoardNail : MGrabbable
	{
		[SerializeField]
		private Transform _grabNail;

		[SerializeField]
		private Transform _stickNail;

		[SerializeField]
		private float _nailMoveSpeed;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		[Header("Limits")]
		private float _distanceLimit;

		[SerializeField]
		private float _yMinClampLimit;

		[SerializeField]
		private float _yMaxClampLimit;

		[SerializeField]
		private float _zMinClampLimit;

		[SerializeField]
		private float _zMaxClampLimit;

		private static Changed<MGrabbableTeamRoomBoardNail> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbableTeamRoomBoardNail> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbableTeamRoomBoardNail> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void FixedUpdateNetwork()
		{
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

		private void DrawLine()
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
