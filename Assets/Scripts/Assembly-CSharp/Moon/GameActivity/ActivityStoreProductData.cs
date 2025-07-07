using System;
using Moon.Shop;
using UnityEngine;

namespace Moon.GameActivity
{
	[Serializable]
	[Obsolete]
	public class ActivityStoreProductData : BaseItemData
	{
		[SerializeField]
		private string _friendlyID;

		public string FriendlyId => null;
	}
}
