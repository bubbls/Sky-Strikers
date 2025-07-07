using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Shop.Exit
{
	public class ShopArenaTrigger : MonoBehaviour
	{
		public enum ShopArena : byte
		{
			Shop = 0,
			CloakRoom = 1,
			Lab = 2
		}

		[SerializeField]
		private ShopArena _shopArena;

		public ShopArena ShopArenaType => default(ShopArena);

		public event Action<bool, ShopArenaTrigger> OnChangeShopArena
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

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
