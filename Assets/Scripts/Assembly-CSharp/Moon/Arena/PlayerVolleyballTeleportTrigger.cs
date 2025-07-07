using System.Collections.Generic;
using UnityEngine;

namespace Moon.Arena
{
	public class PlayerVolleyballTeleportTrigger : MonoBehaviour
	{
		[SerializeField]
		private TeamNo _targetTeamNo;

		[SerializeField]
		private Transform[] _teleportPoints;

		private IEnumerable<string> _cachedIdentifiers;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
