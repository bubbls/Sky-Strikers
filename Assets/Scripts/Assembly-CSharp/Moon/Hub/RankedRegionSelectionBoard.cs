using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using JetBrains.Annotations;
using Moon.Bootstrap;
using Moon.Framework.Base;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class RankedRegionSelectionBoard : MonoBehaviour
	{
		[Serializable]
		private class RankedRegionBoardCacheData
		{
			[Serializable]
			public class RegionCacheInfo
			{
				public string Region;

				public bool Preferred;
			}

			public int DataVersion;

			public List<RegionCacheInfo> PreferredRegions;
		}

		[Serializable]
		private class RegionSlot
		{
			public PlayFabRegion TargetRegion;

			public RankedRegionOption Option { get; private set; }

			public void Initialize(RankedRegionOption option, bool enableOption)
			{
			}

			public void DestroyOption()
			{
			}
		}

		private const string SavedRegionsKey = "RankedRegionSelectionBoard";

		private const string MinRegionsCountNotMetMessage = "YOU MUST HAVE AT LEAST 1 REGION SELECTED!";

		private const string NoChangesWhileSearching = "REGIONS CAN'T BE CHANGED WHILE SEARCHING FOR A GAME!";

		private const string TotalPlayersSearchingMessage = "TOTAL PLAYERS SEARCHING: ";

		private const int CacheDataVersion = 2;

		[SerializeField]
		private PlayFabRegion[] _regionsOrder;

		[SerializeField]
		private List<RegionSlot> _regionSlots;

		[SerializeField]
		private RankedQueueInfoFetcher _rankedQueueInfoFetcher;

		[SerializeField]
		private float _pingUpdateInterval;

		[SerializeField]
		private RankedRegionOption _rankedRegionOptionPrefab;

		[SerializeField]
		private Transform _optionsParent;

		[SerializeField]
		private TMP_Text _notificationText;

		[SerializeField]
		private float _errorNotificationShowTime;

		[SerializeField]
		private Color _errorNotificationColor;

		private IMessageSubscriber _subscriber;

		private RankedRegionBoardCacheData _cacheData;

		private ClientQos _clientQos;

		private int _curScheduledPingUpdateId;

		private bool _boardInputAllowed;

		private bool _isWaitingForFirstUpdate;

		private bool _isShowingError;

		private int _notificationTimerId;

		private uint _playersSearchingForMatchCount;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void ToggleButton_OnValueChanged(RankedRegionOption rankedRegionOption)
		{
		}

		public List<string> GetPreferredRegions()
		{
			return null;
		}

		private int HandleLatencyUpdated(IMessage<object> arg)
		{
			return 0;
		}

		private void UpdateRegionLatencies(List<Latency> latencies)
		{
		}

		private void TryLoadCacheData(out bool isNewData)
		{
			isNewData = default(bool);
		}

		private void SaveCacheData()
		{
		}

		private void SchedulePingUpdate()
		{
		}

		private void ClientQos_OnError()
		{
		}

		private void ClientQos_OnComplete(List<Latency> latencies)
		{
		}

		private void HandleOnLatenciesUpdated(List<Latency> latencies)
		{
		}

		private void GenerateRegionSlots(List<Latency> latencies, bool isNewData)
		{
		}

		private void AssignSlotOption(RegionSlot slot, bool isNewData)
		{
		}

		[UsedImplicitly]
		[Button("Delete Saved Regions", EButtonEnableMode.Always)]
		private void DeleteSavedRegions()
		{
		}

		private void ShowNotification(string text)
		{
		}

		public void ToggleBoardInput(bool enable)
		{
		}

		private void RankedQueueInfoFetcher_OnPlayerCountFetched(uint count)
		{
		}

		private void UpdatePlayersSearchingCountText()
		{
		}

		public void CancelPlayerCountFetching()
		{
		}
	}
}
