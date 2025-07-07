using Chamber8.Framework.Common;
using Moon.Hub;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaPreparationRoomManager : SingleMonoBehaviour<ArenaPreparationRoomManager, DefaultSingleMonoBehaviourSettings<ArenaPreparationRoomManager>>, IAdditionalScene
	{
		[SerializeField]
		private ArenaPreparationRoom _teamOneRoom;

		[SerializeField]
		private ArenaPreparationRoom _teamTwoRoom;

		private bool _shouldTeleportPlayer;

		public void TeleportPlayerToRoom()
		{
		}

		public void MoveTo(AdditionalSceneHandler additionalSceneHandler)
		{
		}

		public void Hide()
		{
		}

		private void MoveToOtherPlaceWithPlayer(Transform otherPlace)
		{
		}

		private void MoveToOtherPlace(Transform otherPlace)
		{
		}
	}
}
