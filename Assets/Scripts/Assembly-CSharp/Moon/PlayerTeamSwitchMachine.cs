using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.Hub;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon
{
	public class PlayerTeamSwitchMachine : MonoBehaviour
	{
		[SerializeField]
		private ManualButton _button;

		[SerializeField]
		private GameObject[] _lights;

		[SerializeField]
		private PlayerTeamObjectsGroup _teamChangeVisualObjectsGroup;

		private IMessageSubscriber[] _subscribers;

		private TeamNo _targetTeamNo;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Button_OnPressed()
		{
		}

		private int HandleMPlayerSpawnedMessage(IMessage<MPlayer> message)
		{
			return 0;
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void UpdateMachineState(TeamNo curPlayerTeamNo)
		{
		}

		private void TryToggleSwitchButton()
		{
		}

		private int HandleMatchEventMessage(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void ConnectionManager_OnConnChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}

		private int HandleGeneralMessage(IMessage<GeneralMessage> message)
		{
			return 0;
		}
	}
}
