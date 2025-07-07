using Cinemachine;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(0)]
	public class PlayerFollowCameraController : NetworkBehaviour
	{
		[SerializeField]
		private GameObject _activatedVisuals;

		[SerializeField]
		private Camera _camera;

		[SerializeField]
		private CinemachineBrain _cinemachineBrain;

		[SerializeField]
		private CinemachineVirtualCamera _cinemachineVirtualCamera;

		[SerializeField]
		private CinemachineCollider _cinemachineCollider;

		[SerializeField]
		private float _distanceFromPlayer;

		[SerializeField]
		private float _yHeight;

		private CinemachineTransposer _transposer;

		private static Changed<PlayerFollowCameraController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<PlayerFollowCameraController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<PlayerFollowCameraController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public static PlayerFollowCameraController Instance { get; private set; }

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void Activate(MPlayer player)
		{
		}

		[ContextMenu("Deactivate")]
		public void Deactivate()
		{
		}

		[ContextMenu("Follow Local Player")]
		private void FollowLocalPlayer()
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
