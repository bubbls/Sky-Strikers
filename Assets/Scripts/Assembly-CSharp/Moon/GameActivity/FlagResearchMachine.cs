using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using Moon.Leaderboard;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.GameActivity
{
	public class FlagResearchMachine : MonoBehaviour
	{
		[Serializable]
		private class EnergyPlugSettings
		{
			public FlagFrameItemDefinition Definition;

			public EnergyPlug EnergyPlug;
		}

		private const string FlagFrameThemeKey = "FlagFrameTheme";

		[SerializeField]
		private List<EnergyPlugSettings> _items;

		[SerializeField]
		private TMP_Text _textProgress;

		[SerializeField]
		private SoundInfo _sfxEnergyReady;

		[SerializeField]
		private SoundInfo _sfxFirstLevelCompleted;

		[SerializeField]
		private SoundInfo _sfxStartResearch;

		[SerializeField]
		private SoundInfo _sfxEquip;

		private IMessageSubscriber[] _subscribers;

		private Coroutine _equipCoroutine;

		private void Awake()
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

		private int HandlePlayerInventoryUpdated(IMessage<object> _)
		{
			return 0;
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> _)
		{
			return 0;
		}

		private int HandlePlayerBalanceChanged(IMessage<object> _)
		{
			return 0;
		}

		private void HandleRequestEquip(EnergyPlug plug, bool equip)
		{
		}

		private void HandleRequestResearch(EnergyPlug plug, Action<bool> complete)
		{
		}

		private static void PurchaseItem(EnergyPlugSettings item, Action<bool> complete)
		{
		}

		private int GetFirstNotPurchasedLevel()
		{
			return 0;
		}

		private static bool UpdateFlagFrameConfiguration(ref FlagFrameConfiguration configuration, FlagThemeLocation location, FlagFrameTheme theme)
		{
			return false;
		}

		private static void UpdateFlagFrameConfiguration(FlagThemeLocation location, FlagFrameTheme theme)
		{
		}

		private static void SyncLocalData(FlagFrameConfiguration configuration)
		{
		}

		public static void SaveFlagFrameConfiguration(FlagFrameConfiguration configuration)
		{
		}

		public static FlagFrameConfiguration LoadFlagFrameConfiguration()
		{
			return default(FlagFrameConfiguration);
		}

		private void UpdateInProgressItem(bool playEnergyReadySound = false)
		{
		}

		private void UpdateItems()
		{
		}

		private void UpdateFlagFrame(int notPurchasedLevel)
		{
		}

		private static bool IsThemePurchased(FlagThemeLocation location, FlagFrameTheme theme)
		{
			return false;
		}

		public static void VerifyPlayerStatsFrameConfiguration(ref FlagFrameConfiguration frameConfiguration)
		{
		}
	}
}
