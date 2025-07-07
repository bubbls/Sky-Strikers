using Moon.Hub;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaPreparationRoomSceneHandler : AdditionalSceneHandler
	{
		[SerializeField]
		private Transform _teamOneRoomPoint;

		[SerializeField]
		private Transform _teamTwoRoomPoint;

		public Transform TeamOneRoomPoint => null;

		public Transform TeamTwoRoomPoint => null;
	}
}
