using Chamber8.Framework.Common;
using Moon.Arena;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class GameMap : SingleMonoBehaviour<GameMap, InSceneSingleMonoBehaviourSettings>
	{
		[SerializeField]
		private Transform _spawnPointsParent;

		[SerializeField]
		private Transform _observerSpawnPoint;

		[SerializeField]
		private TeamSpawnPoint[] _teamSpawnPoints;

		public Transform GetSpawnPoint()
		{
			return null;
		}

		public Transform GetObserverSpawnPoint()
		{
			return null;
		}

		public Transform GetRandomTeamSpawnPoint(TeamNo teamNo)
		{
			return null;
		}
	}
}
