using UnityEngine;

namespace Moon.Arena
{
	public class GenericTeamDeadzone : TeamDeadzone
	{
		[SerializeField]
		private TeamSpawnPoint[] _teamSpawnPoints;

		public override bool TryGetRespawnPointForTeam(TeamNo teamNo, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			return false;
		}
	}
}
