using System;

namespace Moon
{
	[Serializable]
	public class PlayerVisualsCachedConfigData
	{
		[Serializable]
		public class VisualCacheData
		{
			public string Theme;

			public VisualCacheData(string theme)
			{
			}
		}

		[Serializable]
		public class HeadVisualCacheData : VisualCacheData
		{
			public HeadVisualCacheData(string theme)
				: base(null)
			{
			}
		}

		[Serializable]
		public class BodyVisualCacheData : VisualCacheData
		{
			public BodyVisualCacheData(string theme)
				: base(null)
			{
			}
		}

		[Serializable]
		public class LegVisualCacheData : VisualCacheData
		{
			public LegVisualCacheData(string theme)
				: base(null)
			{
			}
		}

		[Serializable]
		public class SuitVisualCacheData : VisualCacheData
		{
			public SuitVisualCacheData(string theme)
				: base(null)
			{
			}
		}

		[Serializable]
		public class SuitWeaponVisualCacheData : VisualCacheData
		{
			public SuitWeaponVisualCacheData(string theme)
				: base(null)
			{
			}
		}

		[Serializable]
		public class BackpackVisualCacheData : VisualCacheData
		{
			public BackpackVisualCacheData(string theme)
				: base(null)
			{
			}
		}

		[Serializable]
		public class NameTagVisualCacheData : VisualCacheData
		{
			public NameTagVisualCacheData(string theme)
				: base(null)
			{
			}
		}

		public HeadVisualCacheData Head;

		public BodyVisualCacheData Body;

		public LegVisualCacheData Leg;

		public SuitVisualCacheData Suit;

		public SuitWeaponVisualCacheData SuitWeapon;

		public BackpackVisualCacheData Backpack;

		public NameTagVisualCacheData NameTag;

		public static PlayerVisualsCachedConfigData Copy(PlayerVisualsCachedConfigData cachedVisualConfig)
		{
			return null;
		}

		public static PlayerVisualsCachedConfigData DefaultBase()
		{
			return null;
		}

		public static PlayerVisualsCachedConfigData DefaultPrime()
		{
			return null;
		}

		public static PlayerVisualsCachedConfigData DefaultJetstream()
		{
			return null;
		}

		public static PlayerVisualsCachedConfigData DefaultBulwarp()
		{
			return null;
		}
	}
}
