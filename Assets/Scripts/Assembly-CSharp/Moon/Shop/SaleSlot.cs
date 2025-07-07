using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Chamber8.Framework.Service.PlayFab;
using DP.Takeaway.Inspector;
using DP.Takeaway.Utils;
using Moon.Analytics;
using Moon.Economy;
using Moon.Hub;
using NaughtyAttributes;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Moon.Shop
{
	public class SaleSlot : SaleSlotBase
	{
		[PossibleStringValues(new string[] { "Slot Main", "Slot A", "Slot B", "Slot C", "Slot D", "Slot E", "Slot F", "Slot Discount" })]
		[SerializeField]
		private string _slotName;

		[SerializeField]
		private LogToSession? _logToSession;

		[SerializeField]
		private SaleSlotConsole? _saleSlotConsole;

		private PlayerSlotObject? _slotObject;

		private SkuData? _skuData;

		private PlayerEconomy _playerEconomy;

		private IMessageSubscriber[]? _subscribers;

		private readonly Cooldown _cooldown;

		private Coroutine? _purchaseRoutine;

		protected readonly CatalogPriceAmount[]? _displayPrices;

		protected readonly Dictionary<PriceIndex, CatalogPriceAmount> _priceIndexPrices;

		protected int _cachedPriceCount;

		private const string QARole = "QARole";

		private const string QAValue = "QA";

		[SerializeField]
		private ManualButton? _testButton;

		[SerializeField]
		private ManualButton? _refreshButton;

		[SerializeField]
		private string? _testingSkuFriendlyId;

		private int _debugTestingSkuIndex;

		private PlayerSlotObject? _savedSlotObject;

		private bool _debugIsTestingSkus;

		public override SkuData? SkuData => null;

		public override bool IsValid => false;

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

		private int HandleStoreOrInventoryChanged(IMessage<object> _)
		{
			return 0;
		}

		private void Update()
		{
		}

		private void Refresh(Dictionary<string, object>? parameters = null)
		{
		}

		private bool ShouldRefresh()
		{
			return false;
		}

		[Button(null, EButtonEnableMode.Always)]
		public void UpdateSlot()
		{
		}

		private void UpdateSlotObject()
		{
		}

		public override TimeSpan GetCountdown()
		{
			return default(TimeSpan);
		}

		private ItemOrderRequest GenerateItemOrderRequest(PriceIndex priceIndex)
		{
			return null;
		}

		public override int GetDisplayPrices(out Dictionary<PriceIndex, CatalogPriceAmount> displayPrices)
		{
			displayPrices = null;
			return 0;
		}

		private void Purchase(PriceIndex priceIndex)
		{
		}

		private void RegisterEvents(bool register)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void DebugRefresh()
		{
		}

		private void HandleRefreshButtonPressed()
		{
		}

		private void HandleTestButtonPressed()
		{
		}

		private void UpdateTestButton()
		{
		}

		private void EnableDebugButtons(bool b)
		{
		}

		private void DebugStartTestSkus()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void DebugNextSku()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void DebugSelectTestingSku()
		{
		}

		private void DebugStopTestSkus()
		{
		}
	}
}
