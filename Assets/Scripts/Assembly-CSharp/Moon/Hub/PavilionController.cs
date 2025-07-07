using UnityEngine;

namespace Moon.Hub
{
	public class PavilionController : MonoBehaviour
	{
		[SerializeField]
		private DoorController _doorCtrl;

		[SerializeField]
		private PlayerTeleportVolume _teleportVolumeEnter;

		[SerializeField]
		private PlayerTeleportVolume _teleportVolumeExit;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTeleportedAway()
		{
		}

		private void OnTeleportedHere()
		{
		}

		private void OnDoorStarted()
		{
		}

		private void OnDoorAnimated()
		{
		}
	}
}
