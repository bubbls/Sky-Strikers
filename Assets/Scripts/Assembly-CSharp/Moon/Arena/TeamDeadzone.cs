using UnityEngine;

namespace Moon.Arena
{
	public abstract class TeamDeadzone : MonoBehaviour, IDeadzoneInfo
	{
		public abstract bool TryGetRespawnPointForTeam(TeamNo teamNo, out Vector3 position, out Quaternion rotation);
	}
}
