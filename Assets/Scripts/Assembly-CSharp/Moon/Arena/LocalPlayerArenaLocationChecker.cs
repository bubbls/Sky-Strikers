using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Arena
{
	public class LocalPlayerArenaLocationChecker : MonoBehaviour
	{
		[SerializeField]
		private LocalPlayerCheckVolume _teamRoomVolume;

		[SerializeField]
		private LocalPlayerCheckVolume _elevatorVolume;

		[SerializeField]
		private LocalPlayerCheckVolume _arenaTunnelVolume;

		[SerializeField]
		private LocalPlayerCheckVolume _arenaFieldVolume;

		public event Action<bool> ElevatorStatusChanged
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

		public event Action<bool> TeamRoomStatusChanged
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

		public event Action<bool> ArenaTunnelStatusChanged
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

		public event Action<bool> ArenaFieldStatusChanged
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

		private void SendEvent(ref Action<bool> action, bool status)
		{
		}

		public bool HasPlayerInDoorControlledArea()
		{
			return false;
		}

		public bool HasPlayerInTeamRoom()
		{
			return false;
		}

		public bool HasPlayerInElevator()
		{
			return false;
		}

		public bool HasPlayerInArenaTunnel()
		{
			return false;
		}

		public bool HasPlayerInArenaField()
		{
			return false;
		}
	}
}
