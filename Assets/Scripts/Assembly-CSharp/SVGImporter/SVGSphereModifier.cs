using UnityEngine;

namespace SVGImporter
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(ISVGRenderer))]
	[AddComponentMenu("Rendering/SVG Modifiers/Sphere Modifier", 22)]
	public class SVGSphereModifier : SVGModifier
	{
		public Transform center;

		public float radius;

		public float intensity;

		protected override void PrepareForRendering(SVGLayer[] layers, SVGAsset svgAsset, bool force)
		{
		}
	}
}
