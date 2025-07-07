using System;
using UnityEngine;

namespace Moon.Shop.Sale
{
	[Serializable]
	public class WeaponTierVisualConfig
	{
		[Serializable]
		public class TierVisualsConfig
		{
			public Renderer Renderer;

			public bool Enable;

			public Material Material;
		}

		public TierVisualsConfig[] TierVisuals;
	}
}
