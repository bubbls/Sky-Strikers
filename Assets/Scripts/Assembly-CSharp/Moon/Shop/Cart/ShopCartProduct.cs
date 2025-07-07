using System;
using DP.Takeaway.VisualScripting;
using UnityEngine;

namespace Moon.Shop.Cart
{
	[Obsolete]
	[RequireComponent(typeof(CustomEventHandler))]
	public class ShopCartProduct : ShopProduct
	{
		public override void Dispose()
		{
		}
	}
}
