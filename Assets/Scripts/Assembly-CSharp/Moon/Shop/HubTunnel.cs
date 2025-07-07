using DG.Tweening;
using UnityEngine;

namespace Moon.Shop
{
	public class HubTunnel : MonoBehaviour
	{
		private enum TunnelType : byte
		{
			UpDown = 0,
			LeftRight = 1
		}

		[SerializeField]
		private Transform _doorPart1;

		[SerializeField]
		private Transform _doorPart2;

		[SerializeField]
		private float _openDuration;

		[SerializeField]
		private float _closeDuration;

		[SerializeField]
		private TunnelType _tunnelType;

		[SerializeField]
		private HubTunnelTrigger _tunnelTrigger;

		private Sequence _sequence;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ToggleDoorAlwaysOpen(bool openDoor)
		{
		}

		public void ToggleTunnelTrigger(bool enable)
		{
		}

		private void Play(bool openDoor)
		{
		}

		private void HandleOnPlayerInside(bool isInside)
		{
		}

		private void UpDownDoorAnimation(bool isInside)
		{
		}

		private void LeftRightDoorAnimation(bool isInside)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
