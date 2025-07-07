using UnityEngine;

namespace SVGImporter
{
	[RequireComponent(typeof(ISVGRenderer))]
	[ExecuteInEditMode]
	[AddComponentMenu("Rendering/SVG Modifiers/Color Modifier", 22)]
	public class SVGColorModifier : SVGModifier
	{
		public enum Mode
		{
			Replace = 0,
			Additive = 1,
			Multiply = 2,
			Blend = 3
		}

		public Mode mode;

		public Color color;

		public float alphaMultiplier;

		protected override void PrepareForRendering(SVGLayer[] layers, SVGAsset svgAsset, bool force)
		{
		}

		private void BlendSelection(SVGLayer[] layers)
		{
		}

		private void Blend(SVGLayer[] layers)
		{
		}

		private void AddSelection(SVGLayer[] layers)
		{
		}

		private void Add(SVGLayer[] layers)
		{
		}

		private void ReplaceSelection(SVGLayer[] layers)
		{
		}

		private void Replace(SVGLayer[] layers)
		{
		}

		private void MultiplySelection(SVGLayer[] layers)
		{
		}

		private void Multiply(SVGLayer[] layers)
		{
		}
	}
}
