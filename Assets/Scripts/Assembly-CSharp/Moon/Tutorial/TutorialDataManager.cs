using System;
using System.Collections.Generic;
using DP.Takeaway.Game;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialDataManager : MonoBehaviour
	{
		[Serializable]
		private class TutorialData
		{
			public bool HasCompletedTutorialV2Flag;

			public TutorialPathData UserTutorialPathData;

			public TutorialCompletedChallengesData UserTutorialChallengeData;
		}

		[Serializable]
		private class TutorialPathData
		{
			public List<string> CompletedTutorialPaths;
		}

		[Serializable]
		private class TutorialCompletedChallengesData
		{
			public bool HasRecordedChallengeDurationFlag;

			public List<string> CompletedChallengesIdList;

			public List<string> GainedChallengesRewardsIdList;
		}

		[SerializeField]
		private List<TutorialChallengeFreeCurrencyReward> _tutorialChallengeFreeCurrencyRewards;

		[SerializeField]
		private Trigger _trigger;

		private const string UserTutorialDataKey = "UserTutorialData";

		private static float _playerStayInChallengeAreaTimer;

		private static int _playerStayInChallengeAreaDuration;

		private static TutorialData CachedTutorialData { get; set; }

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnEnter(Collider other)
		{
		}

		private void HandleOnExit(Collider other)
		{
		}

		public static void LogStayChallengeAreaDuration(string suitClass)
		{
		}

		public static bool HasGainedTutorialChallengeRewardById(string rewardId)
		{
			return false;
		}

		public static bool HasCompletedTutorialChallengeById(string challengeId)
		{
			return false;
		}

		public static bool HasCompletedTutorialV2()
		{
			return false;
		}

		public static bool HasRecordedChallengeDuration()
		{
			return false;
		}

		private static bool HasCompletedTutorialPathById(string suitClass)
		{
			return false;
		}

		public static void MarkTutorialV2Done()
		{
		}

		public static void MarkTutorialChallengeRewardGainedById(string rewardId, int amount, string suitClass)
		{
		}

		public static void MarkTutorialPathCompletedById(string suitClass, int completedDuration)
		{
		}

		public static void MarkTutorialChallengeDoneById(string challengeId)
		{
		}

		private static void MarkHasRecordedChallengeDuration()
		{
		}

		public static void SetUserTutorialData()
		{
		}

		private static string ToLowerFirstLetter(string convertString)
		{
			return null;
		}
	}
}
