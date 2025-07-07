using System.Collections.Generic;
using UnityEngine;

namespace Moon.Arena
{
	public class PlayerTeamSwitchWall : MonoBehaviour
	{
		[SerializeField]
		private TeamNo _targetTeamNo;

		private IEnumerable<string> _cachedIdentifiers;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
