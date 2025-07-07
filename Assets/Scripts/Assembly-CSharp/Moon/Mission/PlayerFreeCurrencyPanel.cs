using System.Collections.Generic;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using Moon.Economy;
using TMPro;
using UnityEngine;

namespace Moon.Mission
{
	public class PlayerFreeCurrencyPanel : SingleMonoBehaviour<PlayerFreeCurrencyPanel, InSceneSingleMonoBehaviourSettings>
	{
		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private TMP_Text _missionPointsText;

		[SerializeField]
		private float _missionPointsTweenDuration;

		private PlayerEconomy _playerEconomy;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private float _currentFreeCurrency;

		private Tween _tween;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleOnPlayerInventoryUpdated(IMessage<object> message)
		{
			return 0;
		}

		public void Toggle(bool enable)
		{
		}

		private void UpdateFreeCurrency(int freeCurrencyBalance)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
