using SVGImporter;
using UnityEngine;

namespace Moon.Leaderboard
{
	[CreateAssetMenu(fileName = "FlagFrameThemeSettings", menuName = "Moon/Flag Frame/FlagFrameThemeSettings")]
	public class FlagFrameThemeSettings : ScriptableObject
	{
		[SerializeField]
		private SVGAsset _portraitFrame;

		[SerializeField]
		private Sprite _portraitFrameMask;

		[SerializeField]
		private SVGAsset _statsFrame;

		[SerializeField]
		public Color StatsFrameNameColor;

		[SerializeField]
		public Color StatsFrameNumberColor;

		[SerializeField]
		public Color DescriptionTextColor;

		[SerializeField]
		private SVGAsset _playerNameBoardBg;

		[SerializeField]
		private SVGAsset _medal01;

		[SerializeField]
		public string Medal01Text;

		[SerializeField]
		public Color Medal01TextColor;

		[SerializeField]
		private SVGAsset _medal02;

		[SerializeField]
		public string Medal02Text;

		[SerializeField]
		public Color Medal02TextColor;

		[SerializeField]
		private SVGAsset _medal03;

		[SerializeField]
		public string Medal03Text;

		[SerializeField]
		public Color Medal03TextColor;

		public SVGAsset PortraitFrame => null;

		public Sprite PortraitFrameMask => null;

		public SVGAsset StatsFrame => null;

		public SVGAsset PlayerNameBoardBg => null;

		public SVGAsset Medal01 => null;

		public SVGAsset Medal02 => null;

		public SVGAsset Medal03 => null;
	}
}
