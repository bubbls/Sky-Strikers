using System.Collections.Generic;
using DP.Takeaway.Game;
using UnityEngine;

namespace Moon.Hub
{
	public class Entrance : MonoBehaviour
	{
		[SerializeField]
		private DoorController _doorAController;

		[SerializeField]
		private List<GameObject> _doorAVisuals;

		[SerializeField]
		private DoorController _doorBController;

		[SerializeField]
		private List<GameObject> _doorBVisuals;

		[SerializeField]
		private Trigger _triggerDoorA;

		[SerializeField]
		private Trigger _triggerDoorB;

		[SerializeField]
		private Trigger _triggerCenter;

		[SerializeField]
		private bool _hideOpenedDoor;

		[SerializeField]
		private PlayerTeleportVolume _teleportVolume;

		[SerializeField]
		private bool _openDoorAAfterTeleportHere;

		[SerializeField]
		private bool _openDoorBAfterTeleportHere;

		[SerializeField]
		private Entrance _otherEntrance;

		private bool _disableCloseBothDoorTrigger;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleBeforeTeleportedHere()
		{
		}

		private void CloseBothDoors(bool immediate)
		{
		}

		private void HandleTeleportedHere()
		{
		}

		private void OnDoorACompleted()
		{
		}

		private void OnDoorBCompleted()
		{
		}

		private void OnTriggerDoorAEnter(Collider _)
		{
		}

		private void OnTriggerDoorBEnter(Collider _)
		{
		}

		private void OnTriggerCenterEnter(Collider _)
		{
		}

		private void OnTriggerCenterExit(Collider _)
		{
		}

		private static void ShowVisuals(List<GameObject> visuals, bool show)
		{
		}
	}
}
