using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Sound;
using Moon.Framework.Leaderboard;
using UnityEngine;

namespace Moon.GameActivity
{
	public class RewardMachine : MonoBehaviour
	{
		[SerializeField]
		private GameObjectToggle[] _rankToggles;

		[SerializeField]
		private SoundInfo _sfxRankChanged;

		private IMessageSubscriber[] _subscribers;

		private LeaderboardEntry? _myLeaderboardEntry;

		private Sequence _sequence;

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleRemoteConfigUpdated(IMessage<object> arg)
		{
			return 0;
		}

		private int HandleLeaderboardUpdated(IMessage<object> arg)
		{
			return 0;
		}

		private void UpdateRewardRank(bool immediate, bool forceUpdate = false)
		{
		}

		private void ChangeRank(LeaderboardEntry? current, bool immediate, bool forceUpdate)
		{
		}

		private void ToggleOn(int rank)
		{
		}

		private void ToggleAllOff()
		{
		}
	}
}
