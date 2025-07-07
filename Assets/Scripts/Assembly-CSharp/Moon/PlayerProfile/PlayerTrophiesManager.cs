using Chamber8.Framework.Messaging;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.PlayerProfile
{
	public class PlayerTrophiesManager : MonoBehaviour
	{
		[SerializeField]
		private PlayerTrophyDefinitionManager _definitionManager;

		[SerializeField]
		private PlayerTrophy[] _playerTrophies;

		private IMessageSubscriber _subscriber;

		private void Start()
		{
		}

		private void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> playerInfoChangedMessage)
		{
			return 0;
		}

		private void UpdatePlayerTrophies()
		{
		}
	}
}
