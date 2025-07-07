using System;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public class TeamSpawnPoint
	{
		public TeamNo TeamNo;

		public Transform[] SpawnPoints;
	}
}
