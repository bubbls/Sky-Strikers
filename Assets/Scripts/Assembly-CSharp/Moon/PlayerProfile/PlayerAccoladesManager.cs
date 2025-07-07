using Chamber8.Framework.Messaging;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.PlayerProfile
{
	public class PlayerAccoladesManager : MonoBehaviour
	{
		private PlayerAccoladeVisualizer[] _accoladeVisualizers;

		private IMessageSubscriber _subscriber;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> playerInfoChangedMessage)
		{
			return 0;
		}

		public void UpdateAllVisualizersForPlayer(MPlayer player, PlayerInfo playerInfo)
		{
		}
	}
}
