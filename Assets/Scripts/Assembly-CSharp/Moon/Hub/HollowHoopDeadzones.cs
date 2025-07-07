using Moon.Arena;
using UnityEngine;

namespace Moon.Hub
{
	public class HollowHoopDeadzones : TeamDeadzone
	{
		public override bool TryGetRespawnPointForTeam(TeamNo teamNo, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			return false;
		}
	}
}
