using System;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;
using TMPro;
using UnityEngine;

namespace Moon.Shop
{
	public class DailyRewardDisplayPanel : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _time;

		[SerializeField]
		private DailyRewardItem[] _items;

		private PlayFabCatalogItemService _catalogItemService;

		private bool _initialized;

		public void Initialize(DailyRewardConfig configs, DailyRewardSetting juiceSetting, DailyRewardSetting currencySetting)
		{
		}

		private TimeSpan CalculateTime()
		{
			return default(TimeSpan);
		}

		public void FlagClaimed(DailyRewardInfo info)
		{
		}

		public TimeSpan? UpdateTime()
		{
			return null;
		}
	}
}
