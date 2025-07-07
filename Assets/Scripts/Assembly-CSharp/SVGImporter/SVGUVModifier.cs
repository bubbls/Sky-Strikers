using UnityEngine;

namespace SVGImporter
{
	[AddComponentMenu("Rendering/SVG Modifiers/UV Modifier", 22)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(ISVGShape), typeof(ISVGRenderer))]
	public class SVGUVModifier : SVGModifier
	{
		public enum TransformOrder
		{
			TRS = 0,
			TSR = 1,
			RTS = 2,
			RST = 3,
			STR = 4,
			SRT = 5
		}

		public Vector2 position;

		public float rotation;

		public Vector2 scale;

		public bool preprocess;

		public TransformOrder transformOrder;

		protected override void PrepareForRendering(SVGLayer[] layers, SVGAsset svgAsset, bool force)
		{
		}
	}
}
