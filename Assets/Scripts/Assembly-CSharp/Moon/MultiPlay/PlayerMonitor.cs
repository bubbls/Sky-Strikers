using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class PlayerMonitor : MonoBehaviour
	{
		private void Awake()
		{
		}

		private int HandleMPlayerContainerSpawnedMessage(IMessage<MPlayerContainer> message)
		{
			return 0;
		}

		private int HandleMPlayerSpawnedMessage(IMessage<MPlayer> message)
		{
			return 0;
		}

		private bool IsContainerAndPlayerValid(MPlayerContainer playerContainer, MPlayer player)
		{
			return false;
		}

		private void NotifyPlayerFullyInitialized(MPlayer player, MPlayerContainer container)
		{
		}
	}
}
