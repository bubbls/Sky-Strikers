using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class VoteMachineOptionWithIcon : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _tmpText;

		[SerializeField]
		private SVGImage _svgImage;

		public void ApplyConfig(string text, SVGAsset svgAsset, float scale = 1f)
		{
		}
	}
}
