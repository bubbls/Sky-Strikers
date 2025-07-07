using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	public class TeamRoomLockerManager : MonoBehaviour
	{
		[SerializeField]
		private SkinPresetLocker[] _teamOneLockers;

		[SerializeField]
		private SkinPresetLocker[] _teamTwoLockers;

		public void UpdateTeamOneLockers(PlayerRef[] players)
		{
		}

		public void UpdateTeamTwoLockers(PlayerRef[] players)
		{
		}

		private void UpdateLockers(PlayerRef[] players, ref SkinPresetLocker[] lockers)
		{
		}
	}
}
