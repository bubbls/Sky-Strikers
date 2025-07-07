using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;

namespace Moon.Shop
{
	public class ShopProductsChecker : Singleton<ShopProductsChecker>
	{
		private readonly Dictionary<SuitVisualTheme, SkuData> _purchasedSkinsTheme;

		private readonly Dictionary<SuitWeaponVisualTheme, SkuData> _purchasedWeaponsTheme;

		private readonly Dictionary<AvatarBodyVisualTheme, SkuData> _purchasedBodiesTheme;

		private readonly Dictionary<AvatarLegVisualTheme, SkuData> _purchasedLegsTheme;

		private readonly Dictionary<AvatarHeadVisualTheme, SkuData> _purchasedHeadsTheme;

		private readonly Dictionary<BackpackVisualTheme, SkuData> _purchasedBackpacksTheme;

		private readonly Dictionary<NameTagVisualTheme, SkuData> _purchasedNameTagTheme;

		public IReadOnlyDictionary<SuitVisualTheme, SkuData> PurchasedSkins => null;

		public IReadOnlyDictionary<SuitWeaponVisualTheme, SkuData> PurchasedWeapons => null;

		public IReadOnlyDictionary<AvatarBodyVisualTheme, SkuData> PurchasedBodies => null;

		public IReadOnlyDictionary<AvatarLegVisualTheme, SkuData> PurchasedLegs => null;

		public IReadOnlyDictionary<AvatarHeadVisualTheme, SkuData> PurchasedHeads => null;

		public IReadOnlyDictionary<BackpackVisualTheme, SkuData> PurchasedBackpacks => null;

		public IReadOnlyDictionary<NameTagVisualTheme, SkuData> PurchasedNameTags => null;

		public event Action? OnPurchasedProductUpdated
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

		protected override void Initialize()
		{
		}

		protected override void Dispose()
		{
		}

		private void HandlePurchasedSkusUpdated()
		{
		}

		public bool HasPurchased(SuitVisualTheme visualTheme)
		{
			return false;
		}

		public bool HasPurchased(SuitWeaponVisualTheme suitWeaponTheme)
		{
			return false;
		}

		public bool HasPurchased(AvatarHeadVisualTheme avatarHeadVisualTheme)
		{
			return false;
		}

		public bool HasPurchased(AvatarBodyVisualTheme avatarHeadVisualTheme)
		{
			return false;
		}

		public bool HasPurchased(AvatarLegVisualTheme avatarLegVisualTheme)
		{
			return false;
		}

		public bool HasPurchased(BackpackVisualTheme backpackTheme)
		{
			return false;
		}

		public bool HasPurchased(NameTagVisualTheme nameTagTheme)
		{
			return false;
		}

		public void VerifyPlayerVisualConfig(ref PlayerVisualsConfig visualsConfig, bool onlySetPriceTag = false)
		{
		}

		private void HandleSkinValidity(ref PlayerVisualsSuitPartData visualsSuitPartData, bool onlySetPriceTag)
		{
		}

		private void HandleAvatarHeadValidity(ref PlayerVisualsAvatarHeadData avatarHeadData, SuitVisualTheme fallbackTheme, bool onlySetPriceTag = false)
		{
		}

		private void HandleAvatarBodyValidity(ref PlayerVisualsAvatarBodyData avatarBodyData, SuitVisualTheme fallbackTheme, bool onlySetPriceTag)
		{
		}

		private void HandleAvatarLegValidity(ref PlayerVisualsAvatarLegData legData, SuitVisualTheme fallbackTheme, bool onlySetPriceTag)
		{
		}

		private void HandleBackpackValidity(ref PlayerVisualsBackpackData visualsBackpackData, bool onlySetPriceTag)
		{
		}

		private void HandleNameTagValidity(ref PlayerVisualsNameTagData visualsNameTagData, bool onlySetPriceTag)
		{
		}

		public bool AllPaid(PlayerVisualsConfig visualConfig)
		{
			return false;
		}

		public bool AllPaid(PlayerVisualsCachedConfigData cachedConfig)
		{
			return false;
		}
	}
}
