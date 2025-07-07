using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter
{
	[RequireComponent(typeof(ISVGShape), typeof(ISVGRenderer))]
	[AddComponentMenu("Rendering/SVG Stroke Renderer", 21)]
	[ExecuteInEditMode]
	public class SVGStrokeRenderer : MonoBehaviour, ISVGModify
	{
		public StrokeLineJoin lineJoin;

		public StrokeLineCap lineCap;

		public Color32 color;

		public float width;

		public float mitterLimit;

		public float roundQuality;

		public float[] dashArray;

		public float dashOffset;

		public ClosePathRule closeLine;

		protected ISVGShape svgShape;

		protected ISVGRenderer svgRenderer;

		private void OnWillRenderObject()
		{
		}

		protected virtual void PrepareForRendering(SVGLayer[] layers, SVGAsset svgAsset, bool force)
		{
		}

		private void Init()
		{
		}

		private void Clear()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
