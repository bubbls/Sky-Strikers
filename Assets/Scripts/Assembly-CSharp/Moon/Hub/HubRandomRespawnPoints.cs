using Moon.Arena;
using UnityEngine;

namespace Moon.Hub
{
	public class HubRandomRespawnPoints : MonoBehaviour
	{
		[SerializeField]
		private Transform _teamOneRespawnPointParent;

		[SerializeField]
		private Transform _teamTwoRespawnPointParent;

		public void GetRespawnPointForTeam(TeamNo teamNo, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}
	}
}
