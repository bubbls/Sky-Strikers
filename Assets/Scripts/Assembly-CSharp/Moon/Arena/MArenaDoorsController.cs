using System;
using System.Runtime.CompilerServices;
using Moon.Hub;
using UnityEngine;

namespace Moon.Arena
{
	public class MArenaDoorsController : MonoBehaviour
	{
		public enum LockingType
		{
			None = 0,
			RankedTeamRoomOnly = 1,
			ArenaOnly = 2
		}

		[SerializeField]
		private LocalPlayerArenaLocationChecker _localPlayerArenaLocationChecker;

		[SerializeField]
		private DoorController _teamOneElevatorTunnelDoor;

		[SerializeField]
		private DoorController _teamOneTeamRoomDoor;

		[SerializeField]
		private DoorController _teamOneArenaTunnelDoor;

		[SerializeField]
		private DoorController _teamTwoElevatorTunnelDoor;

		[SerializeField]
		private DoorController _teamTwoTeamRoomDoor;

		[SerializeField]
		private DoorController _teamTwoArenaTunnelDoor;

		private bool _checkPlayerOnField;

		private LockingType _lockingType;

		public event Action OnPlayerExitDoorControlledAreas
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

		private void Awake()
		{
		}

		private void TeamRoomVolume_OnChanged(bool hasPlayer)
		{
		}

		private void ArenaTunnelVolume_OnChanged(bool hasPlayer)
		{
		}

		private void ArenaFieldVolume_OnChanged(bool hasPlayer)
		{
		}

		private void CloseArenaDoors()
		{
		}

		public void EnableTeamRoomOnlyDoors()
		{
		}

		public bool HasPlayerInDoorControlledArea()
		{
			return false;
		}

		public void EnableRankedArenaOnlyDoors()
		{
		}

		public void EnableArenaOnlyDoors()
		{
		}

		public void HandleRankedArenaClosing(TeamNo teamNo)
		{
		}

		public void TryOpenDoorsIfPlayerIsNotInArena()
		{
		}

		public void LockAllDoors()
		{
		}

		public void UnlockAllDoors()
		{
		}

		private void CloseDoorWithAutoTrigger(DoorController door)
		{
		}
	}
}
