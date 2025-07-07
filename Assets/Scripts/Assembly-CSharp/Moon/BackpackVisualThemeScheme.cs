using Moon.Player.Visual;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Theme Schemes/Create Backpack Visual Theme Scheme", fileName = "BackpackVisualThemeScheme", order = 3)]
	public class BackpackVisualThemeScheme : VisualThemeScheme
	{
		public PlayerBackpackVisual BackpackVisual;

		public PlayerMaterial[] TeamMaterials;
	}
}
