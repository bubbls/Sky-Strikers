using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaStateScreensController : MonoBehaviour
	{
		private const string WaitingForPlayers = "WAITING FOR PLAYERS";

		private const string TeamSetup = "ASSIGNING\nTEAMS";

		private const string DoorsOpenIn = "DOORS OPEN IN\n";

		private const string ProceedToArena = "PROCEED TO\nARENA";

		private const string GreatMatch = "GREAT MATCH!\nSEE YOU NEXT TIME!";

		[SerializeField]
		private TMP_Text[] _teamRoomScreens;

		private IMessageSubscriber[] _messageSubscribers;

		private string _baseText;

		private bool _isUpdatingWithTimer;

		private float _curRemainingTime;

		private bool _updatePlayerCount;

		private bool _updateShuttleScreen;

		private string _targetText;

		private Cooldown _cd;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		public bool TryUpdateScreensForState(string state)
		{
			return false;
		}

		public void ClearTeamRoomScreenText()
		{
		}

		private void SetTeamRoomScreensText(string text)
		{
		}

		private void ToggleTeamRoomScreens(bool value)
		{
		}
	}
}
