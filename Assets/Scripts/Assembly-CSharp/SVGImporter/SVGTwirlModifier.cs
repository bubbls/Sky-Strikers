using UnityEngine;

namespace SVGImporter
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(ISVGRenderer))]
	[AddComponentMenu("Rendering/SVG Modifiers/Twirl Modifier", 22)]
	public class SVGTwirlModifier : SVGModifier
	{
		public Transform center;

		public float radius;

		public float intensity;

		protected override void PrepareForRendering(SVGLayer[] layers, SVGAsset svgAsset, bool force)
		{
		}
	}
}
