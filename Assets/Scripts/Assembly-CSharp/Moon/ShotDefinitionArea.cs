using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class ShotDefinitionArea : MonoBehaviour
	{
		[SerializeField]
		private ArenaGoal _arenaGoal;

		public TeamNo AreaTeamNo => default(TeamNo);
	}
}
