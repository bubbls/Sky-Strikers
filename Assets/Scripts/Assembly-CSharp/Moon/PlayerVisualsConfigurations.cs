using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using DP.Takeaway.Runtime;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class PlayerVisualsConfigurations : SingleMonoBehaviour<PlayerVisualsConfigurations, DefaultSingleMonoBehaviourSettings<PlayerVisualsConfigurations>>
	{
		[Serializable]
		private class SuitVisualsThemeSchemes : SerializableDictionary<SuitVisualTheme, SuitVisualThemeScheme>
		{
		}

		[Serializable]
		private class HeldWeaponVisualsThemeSchemes : SerializableDictionary<SuitWeaponVisualTheme, SuitWeaponVisualThemeScheme>
		{
		}

		[Serializable]
		private class AvatarVisualsThemeSchemes : SerializableDictionary<AvatarHeadVisualTheme, AvatarVisualThemeScheme>
		{
		}

		[Serializable]
		private class AvatarBodyVisualsThemeSchemes : SerializableDictionary<AvatarBodyVisualTheme, AvatarVisualThemeScheme>
		{
		}

		[Serializable]
		private class AvatarLegVisualsThemeSchemes : SerializableDictionary<AvatarLegVisualTheme, AvatarVisualThemeScheme>
		{
		}

		[Serializable]
		private class BackpackVisualsThemeSchemes : SerializableDictionary<BackpackVisualTheme, BackpackVisualThemeScheme>
		{
		}

		[Serializable]
		private class NameTagVisualsThemeSchemes : SerializableDictionary<NameTagVisualTheme, NameTagVisualThemeScheme>
		{
		}

		private const string AvatarHeadVisualConfigurationsPath = "PlayerVisualConfigurations/AvatarHead/Head_";

		private const string AvatarBodyVisualConfigurationsPath = "PlayerVisualConfigurations/AvatarBody/Body_";

		private const string AvatarLegVisualConfigurationsPath = "PlayerVisualConfigurations/AvatarLeg/Leg_";

		private const string SuitsVisualConfigurationsPath = "PlayerVisualConfigurations/Suits/Suit_";

		private const string HeldWeaponsVisualConfigurationsPath = "PlayerVisualConfigurations/SuitWeapons/SuitWeapon_";

		private const string BackpacksVisualConfigurationsPath = "PlayerVisualConfigurations/Backpacks/Backpack_";

		private const string NameTagsVisualConfigurationsPath = "PlayerVisualConfigurations/NameTags/NameTag_";

		private static AvatarVisualThemeScheme CachedAvatarThemeScheme;

		private static SuitVisualThemeScheme CachedSuitScheme;

		private static SuitWeaponVisualThemeScheme CachedSuitWeaponScheme;

		private static BackpackVisualThemeScheme CachedBackpackScheme;

		[SerializeField]
		private float _simplifiedPlayerDistance;

		[SerializeField]
		private AnimationCurve _playerSilhouetteCurve;

		[Space(5f)]
		public Color[] TeamBoardColor;

		[Space(5f)]
		public Color[] SilhouetteColor;

		[Space(5f)]
		[SerializeField]
		private SuitVisualsThemeSchemes _suitVisualsThemeSchemes;

		[Space(5f)]
		[SerializeField]
		private HeldWeaponVisualsThemeSchemes _heldWeaponVisualsThemeSchemes;

		[Space(5f)]
		[SerializeField]
		private AvatarVisualsThemeSchemes _avatarHeadVisualsThemeSchemes;

		[SerializeField]
		[Space(5f)]
		private AvatarBodyVisualsThemeSchemes _avatarBodyVisualsThemeSchemes;

		[Space(5f)]
		[SerializeField]
		private AvatarLegVisualsThemeSchemes _avatarLegVisualsThemeSchemes;

		[Space(5f)]
		[SerializeField]
		private BackpackVisualsThemeSchemes _backpackVisualsThemeSchemes;

		[SerializeField]
		[Space(5f)]
		private NameTagVisualsThemeSchemes _nameTagVisualsThemeSchemes;

		private string _cachedPath;

		private VisualThemeScheme _cachedScheme;

		public float SimplifiedPlayerDistance => 0f;

		public AnimationCurve PlayerSilhouetteCurve => null;

		private void Awake()
		{
		}

		private void ClearDictionaries()
		{
		}

		public PlayerMaterial GetTeamMaterialForAvatarHead(AvatarHeadVisualTheme avatarHeadVisualTheme, TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public AvatarVisualThemeScheme GetAvatarHeadScheme(AvatarHeadVisualTheme avatarHeadVisualTheme)
		{
			return null;
		}

		public PlayerMaterial GetTeamMaterialForAvatarBody(AvatarBodyVisualTheme avatarBodyVisualTheme, TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public AvatarVisualThemeScheme GetAvatarBodyScheme(AvatarBodyVisualTheme avatarBodyVisualTheme)
		{
			return null;
		}

		public PlayerMaterial GetTeamMaterialForAvatarLeg(AvatarLegVisualTheme avatarLegVisualTheme, TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public AvatarVisualThemeScheme GetAvatarLegScheme(AvatarLegVisualTheme avatarLegVisualTheme)
		{
			return null;
		}

		public SuitVisualThemeScheme GetSuitScheme(SuitVisualTheme visualTheme)
		{
			return null;
		}

		public PrimeSuitThemeScheme GetPrimeSuitScheme(SuitVisualTheme visualTheme)
		{
			return null;
		}

		public JetstreamSuitThemeScheme GetJetstreamSuitScheme(SuitVisualTheme visualTheme)
		{
			return null;
		}

		public BulwarpSuitThemeScheme GetBulwarpSuitScheme(SuitVisualTheme visualTheme)
		{
			return null;
		}

		public PlayerMaterial GetTeamMaterialForSuit(SuitVisualTheme visualTheme, TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public GameObject GetPlayerChangeLocationTeleportFx(SuitVisualTheme visualTheme, TeamNo teamNo)
		{
			return null;
		}

		public GameObject GetPlayerTeleportToFieldFx(SuitVisualTheme visualTheme, TeamNo teamNo)
		{
			return null;
		}

		public GameObject GetPlayerSpawnedTeleportFx(SuitVisualTheme visualTheme, TeamNo teamNo)
		{
			return null;
		}

		public SuitWeaponVisualThemeScheme GetSuitWeaponScheme(SuitWeaponVisualTheme theme)
		{
			return null;
		}

		public PrimeSuitWeaponVisualThemeScheme GetPrimeSuitWeaponScheme(SuitWeaponVisualTheme theme)
		{
			return null;
		}

		public JetstreamSuitWeaponVisualThemeScheme GetJetstreamSuitWeaponScheme(SuitWeaponVisualTheme theme)
		{
			return null;
		}

		public BulwarpSuitWeaponVisualThemeScheme GetBulwarpSuitWeaponScheme(SuitWeaponVisualTheme theme)
		{
			return null;
		}

		public BallHitFX GetBallHitFx(SuitWeaponVisualTheme suitWeaponVisualTheme)
		{
			return null;
		}

		public GameObject GetGoalHitFx(SuitWeaponVisualTheme suitWeaponVisualTheme, TeamNo teamNo)
		{
			return null;
		}

		public PlayerMaterial GetTeamMaterialForSuitWeapon(SuitWeaponVisualTheme visualTheme, TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public BackpackVisualThemeScheme GetBackpackScheme(BackpackVisualTheme visualTheme)
		{
			return null;
		}

		public PlayerMaterial GetTeamMaterialForBackpack(BackpackVisualTheme visualTheme, TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public NameTagVisualThemeScheme GetNameTagScheme(NameTagVisualTheme visualTheme)
		{
			return null;
		}

		private TScheme GetScheme<TEnumTheme, TScheme>(SerializableDictionary<TEnumTheme, TScheme> schemes, TEnumTheme theme, TEnumTheme fallbackTheme, string configurationPath) where TScheme : VisualThemeScheme
		{
			return null;
		}

		public void TryLoadConfigurations(PlayerVisualsConfig visualsConfig)
		{
		}

		private bool TryLoadConfiguration<TEnumTheme, TScheme>(SerializableDictionary<TEnumTheme, TScheme> schemes, TEnumTheme theme, string pathBase, out TScheme scheme) where TScheme : VisualThemeScheme
		{
			scheme = null;
			return false;
		}

		public void TryUnloadUnusedConfigurations()
		{
		}

		private void TryUnloadConfiguration<TEnumTheme, TScheme>(SerializableDictionary<TEnumTheme, TScheme> schemes, HashSet<TEnumTheme> visualsConfigs)
		{
		}
	}
}
