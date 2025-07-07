using System;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class BaseItemData
	{
		[SerializeField]
		private Sprite[] _displayIcons;

		public Sprite[] DisplayIcons => null;
	}
}
