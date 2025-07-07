using System;
using DP.Takeaway.VisualScripting;
using UnityEngine;

namespace Moon.Shop
{
	[RequireComponent(typeof(CustomEventHandler))]
	public abstract class ShopProduct : MonoBehaviour, IDisposable
	{
		public BaseItemData ProductData { get; private set; }

		public virtual void Initialize(BaseItemData productData)
		{
		}

		public abstract void Dispose();
	}
}
