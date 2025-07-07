using Chamber8.Framework.Messaging;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ScoreBoard : MonoBehaviour
	{
		private static readonly int PropTimeSimulation;

		[SerializeField]
		private TextMeshPro[] _teamOneScore;

		[SerializeField]
		private TextMeshPro[] _teamTwoScore;

		[SerializeField]
		private TextMeshPro[] _gameMode;

		[SerializeField]
		private GameObject[] _maxGoalCount;

		[SerializeField]
		private Material _timerMaterial;

		private TeamScore _scoreOne;

		private TeamScore _scoreTwo;

		private IMessageSubscriber _matchEventsMessageSubscription;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void HandleTimeUpdated(MatchTimeUpdatedMessageData messageData)
		{
		}

		private void UpdateGameModeText(string text)
		{
		}

		private void HandleScoreUpdated(TeamScoresUpdatedMessageData teamScoresMessageData)
		{
		}

		private void UpdateMaxGoal(GameSettings gameSettings)
		{
		}

		private void ShowGameModeText(bool show)
		{
		}

		private void ShowMaxGoalCount(bool show, int maxGoalCount = 0)
		{
		}
	}
}
