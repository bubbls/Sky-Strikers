using System;
using System.Net;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Sound;
using Fusion;
using Moon.Economy;
using Moon.Hub;
using Moon.Mission.Demo;
using Moon.Shop;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.Mission
{
	public class LotteryMachine : MonoBehaviour
	{
		private static readonly int _propSwitch;

		private static readonly int _propPrizeColor;

		private static readonly int _propPrizeColor2;

		private static readonly Color _lightOffColor;

		[SerializeField]
		private TMP_Text _buttonText;

		[SerializeField]
		private TMP_Text _screenText;

		[SerializeField]
		private PrizeBox _prizeBox;

		[SerializeField]
		private PushLockButton _drawPrizeButton;

		[SerializeField]
		private MeshRenderer _lightRenderer;

		[SerializeField]
		private PrizeSpawner _prizeSpawner;

		[SerializeField]
		private CurrencyTransactionTubeRendererController _tubeController;

		[SerializeField]
		[Space(6f)]
		private MissionItemVisualConfig _visualConfig;

		private PriceAmount _priceAmount;

		[SerializeField]
		private SoundInfo _sfxError;

		private const string PrinterStartMessage = "Printer Starting...";

		private const string PrinterIdleMessage = "Press to Print Your Reward";

		private const string ProcessingMessage = "Printing Reward for {0}...";

		private const string ProcessingMessageNoName = "Printing Reward...";

		private const string PrintCompletedMessage = "Print Completed";

		private IMessageSubscriber[] _subscribers;

		private Material _lightMaterial;

		private Sequence _lightTween;

		private PlayerEconomy _playerEconomy;

		public Transform SpawnPoint => null;

		public event Action RequestDrawPrize
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleOnButtonPressed()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void RaiseRequestDrawPrize()
		{
		}

		public void StartDrawPrize(PlayerRef playerRef)
		{
		}

		public void SetFreeToUse()
		{
		}

		public void StartPrint(PlayerRef playerRef, Rarity prizeCategory, Action onReachSpawnPoint)
		{
		}

		public void FinishPrint()
		{
		}

		private void Restart()
		{
		}

		public void SetPrizePool(PrizePool prizePool)
		{
		}

		public void SetBroken(HttpStatusCode errorCode)
		{
		}

		public void SetStartInitializePrizePool()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void LightStartCharging()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void StopLight()
		{
		}

		private void LightPrinted(Rarity rarity)
		{
		}

		public void PlayErrorSfx()
		{
		}
	}
}
