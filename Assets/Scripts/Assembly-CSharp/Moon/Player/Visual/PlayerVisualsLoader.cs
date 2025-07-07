using Chamber8.Framework.Common;
using Fusion;
using Moon.Player.Visuals;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerVisualsLoader : SingleMonoBehaviour<PlayerVisualsLoader, DefaultSingleMonoBehaviourSettings<PlayerVisualsLoader>>
	{
		public bool TryLoadHead(AvatarHeadVisualTheme headVisualTheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerAvatarHeadVisual avatarHead)
		{
			avatarHead = null;
			return false;
		}

		public bool TryLoadBody(AvatarBodyVisualTheme bodyVisualTheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerAvatarBodyVisual avatarBody)
		{
			avatarBody = null;
			return false;
		}

		public bool TryLoadLeg(AvatarLegVisualTheme legVisualTheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerAvatarLegVisual avatarLeg)
		{
			avatarLeg = null;
			return false;
		}

		public bool TryLoadHand(SuitVisualTheme suitVisualTheme, Transform parent, bool isLeft, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerSuitHandVisual suitHand)
		{
			suitHand = null;
			return false;
		}

		public bool TryLoadSuit(SuitVisualTheme suitVisualTheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerSuitArmVisual suitArm)
		{
			suitArm = null;
			return false;
		}

		public bool TryLoadHeldWeapon(SuitWeaponVisualTheme suitWeaponVisualTheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerSuitWeaponVisual suitWeapon)
		{
			suitWeapon = null;
			return false;
		}

		public bool TryLoadBackpack(BackpackVisualTheme backpackVisualTheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerBackpackVisual backpack)
		{
			backpack = null;
			return false;
		}

		public bool TryLoadNameTag(NameTagVisualTheme nameTagVisualTheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out PlayerNameTagVisual nameTag)
		{
			nameTag = null;
			return false;
		}

		private static bool TryLoadAvatarPartVisual<T>(int theme, AvatarVisualThemeScheme themeScheme, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out T visual) where T : PlayerVisualBase
		{
			visual = null;
			return false;
		}

		private static bool TryLoadVisual<T>(int theme, PlayerVisualBase objToInstantiate, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out T visual) where T : PlayerVisualBase
		{
			visual = null;
			return false;
		}

		private static void InitializeVisual<T>(int theme, PlayerVisualBase objToInstantiate, Transform parent, PlayerVisualAttachPointType attachPointType, PlayerRef ownerPlayer, bool isForLocalPlayer, out T visual) where T : PlayerVisualBase
		{
			visual = null;
		}
	}
}
