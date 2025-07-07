using System.Collections.Generic;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using Moon.Economy;
using UnityEngine;

namespace Moon.Mission
{
	public class MissionStore : SingleMonoBehaviour<MissionStore, InSceneSingleMonoBehaviourSettings>
	{
		[SerializeField]
		private MissionStoreProduct[] _missionStoreProducts;

		private PlayerEconomy _playerEconomy;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleInGameStoreProductUpdated(IMessage<object> message)
		{
			return 0;
		}

		private int HandleOnPlayerInventoryUpdated(IMessage<object> message)
		{
			return 0;
		}

		private void UpdateStoreItems()
		{
		}

		private void UpdateStoreRedeemedItems()
		{
		}

		private void HandleOnRequestPurchase(MissionStoreProduct product)
		{
		}
	}
}
