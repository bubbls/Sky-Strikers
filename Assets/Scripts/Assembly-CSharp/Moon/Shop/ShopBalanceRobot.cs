using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using Moon.Economy;
using UnityEngine;

namespace Moon.Shop
{
	[Obsolete]
	public class ShopBalanceRobot : MonoBehaviour
	{
		private static ShopBalanceRobot _instance;

		private static bool _isInitialized;

		[SerializeField]
		private Vector3 _offset;

		[SerializeField]
		private Vector3 _balanceRotation;

		[SerializeField]
		private GameObject _chargeSucceedEffectPrefab;

		[SerializeField]
		private GameObject _purchaseSucceedEffectPrefab;

		[SerializeField]
		private int _purchaseSucceedEffectCount;

		[SerializeField]
		private ShopBalanceRobotText _balanceText;

		private PlayerEconomy _playerEconomy;

		private Transform _robotTransform;

		private Transform _targetPositionTransform;

		private Sequence _sequence;

		private Tweener _moveTween;

		private Color _balanceTextColor;

		private bool _isShowing;

		private int _currentBalance;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		public static ShopBalanceRobot Instance => null;

		public Vector3 Position => default(Vector3);

		public int CurrentBalance => 0;

		private void Initialize()
		{
		}

		private void SubscribeMessages()
		{
		}

		private void UnsubscribeMessages()
		{
		}

		private int HandleOnPlayerBalanceChanged(IMessage<object> message)
		{
			return 0;
		}

		public void ShowChargeSucceed()
		{
		}

		public void UpdateBalance()
		{
		}

		public void ShowPurchaseSucceed(Vector3 targetPosition)
		{
		}

		public void ShowNotEnoughBalance()
		{
		}

		public void Animate(bool animateIn)
		{
		}

		private void ShowShakeEffect()
		{
		}

		private void Update()
		{
		}

		public void EnterChargeMachineArena()
		{
		}

		private void OnDestroy()
		{
		}

		private Vector3[] GetWayPoints(Vector3 targetPosition)
		{
			return null;
		}
	}
}
