using Chamber8.Framework.Messaging;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Class
{
	public class ClassSwitchRoomExitManager : MonoBehaviour
	{
		[SerializeField]
		private GameObject _takeOffSkinFX;

		[SerializeField]
		private GameObject _playerStatsBoardGameObject;

		private IMessageSubscriber _subscriber;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleLocalPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private void ValidateAndSyncPlayerVisuals()
		{
		}
	}
}
