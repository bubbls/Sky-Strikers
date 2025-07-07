using System;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.GameActivity
{
	public class ActivityStore : MonoBehaviour
	{
		private IMessageSubscriber _subscriber;

		public static int Balance => 0;

		public static event Action OnStoreUpdated
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

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private static int HandleInGameStoreProductUpdated(IMessage<object> _)
		{
			return 0;
		}

		private static void UpdateStoreItems()
		{
		}

		public static void Purchase(ActivityStoreProductData productData, Action<bool> complete)
		{
		}

		public static int GetPrice(ActivityStoreProductData productData)
		{
			return 0;
		}

		public static string GetLocalizedPrice(ActivityStoreProductData productData)
		{
			return null;
		}

		public static bool IsPurchased(ActivityStoreProductData productData)
		{
			return false;
		}
	}
}
