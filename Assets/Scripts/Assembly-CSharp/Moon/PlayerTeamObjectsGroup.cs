using System;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public class PlayerTeamObjectsGroup
	{
		[Serializable]
		private class TeamObjectsGroup
		{
			[SerializeField]
			private TeamNo _targetTeam;

			[SerializeField]
			private GameObject[] _targetObjects;

			public void ToggleForTeam(TeamNo teamNo)
			{
			}

			public void ToggleObjects(bool active)
			{
			}
		}

		[SerializeField]
		private TeamObjectsGroup[] _objectsGroups;

		public void ToggleForTeam(TeamNo teamNo)
		{
		}

		public void EnableAllGroups()
		{
		}

		public void DisableAllGroups()
		{
		}
	}
}
