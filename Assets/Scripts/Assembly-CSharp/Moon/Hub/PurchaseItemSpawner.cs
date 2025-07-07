using System;
using Chamber8.Framework.Service.Rpc;
using UnityEngine;

namespace Moon.Hub
{
	public class PurchaseItemSpawner : MonoBehaviour, IRpcServer
	{
		public class ItemData
		{
			public string FriendlyId;
		}

		public class SpawnData
		{
			public ItemData ItemData;

			public int PlayerId;
		}

		[SerializeField]
		private Transform _itemSpawnPoint;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnRequestFromClient(Request request, Action<Response> onComplete)
		{
		}

		public void OnBroadcastFromServer(Request request)
		{
		}
	}
}
