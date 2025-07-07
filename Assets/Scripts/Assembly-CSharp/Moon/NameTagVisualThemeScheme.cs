using Moon.Player.Visuals;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Create NameTag Visual Theme Scheme", fileName = "NameTagVisualThemeScheme", order = 3)]
	public class NameTagVisualThemeScheme : VisualThemeScheme
	{
		public PlayerNameTagVisual NameTagVisual;

		public PlayerMaterial[] TeamMaterials;
	}
}
