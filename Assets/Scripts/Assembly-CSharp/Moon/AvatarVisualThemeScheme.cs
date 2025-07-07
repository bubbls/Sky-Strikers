using Moon.Player.Visual;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Create Avatar Visual Theme Scheme", fileName = "AvatarVisualThemeScheme", order = 1)]
	public class AvatarVisualThemeScheme : VisualThemeScheme
	{
		public PlayerAvatarVisual AvatarVisual;

		public PlayerMaterial[] TeamMaterials;
	}
}
