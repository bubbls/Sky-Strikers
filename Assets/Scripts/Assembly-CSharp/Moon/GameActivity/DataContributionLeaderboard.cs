using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;

namespace Moon.GameActivity
{
	public class DataContributionLeaderboard : MonoBehaviour
	{
		[SerializeField]
		private List<LeaderboardEntryObject> _entries;

		[SerializeField]
		private LeaderboardEntryObject _myEntry;

		[SerializeField]
		private TMP_Text _textDaysLeft;

		private readonly Cooldown _timeUpdateCd;

		private IMessageSubscriber[] _subscribers;

		private Sequence _sequence;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private int HandleLeaderboardUpdated(IMessage<object> _)
		{
			return 0;
		}

		private void UpdateLeaderboard(bool immediate = false)
		{
		}
	}
}
