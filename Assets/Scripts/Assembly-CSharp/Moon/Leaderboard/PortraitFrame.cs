using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class PortraitFrame : FlagTheme
	{
		[SerializeField]
		private SVGRenderer _frameRenderer;

		[SerializeField]
		private SpriteMask _frameMask;

		[SerializeField]
		private TMP_Text _textDesc;

		protected override void UpdateThemeVisualInternal(FlagFrameConfiguration configuration)
		{
		}
	}
}
