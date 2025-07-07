using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Hub
{
	public class HubSpawnPoints : SingleMonoBehaviour<HubSpawnPoints, InSceneSingleMonoBehaviourSettings>
	{
		[SerializeField]
		private Transform _hofSpawnPoint;

		public Transform HofSpawnPoint => null;
	}
}
