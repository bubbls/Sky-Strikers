using UnityEngine;

namespace SVGImporter
{
	public class SVGRenderTexture
	{
		private const int EMPTY_LAYER = 31;

		protected static Camera _camera;

		protected static SVGRenderer _renderer;

		protected static Camera camera => null;

		protected static SVGRenderer renderer => null;

		protected static void RemoveCamera()
		{
		}

		protected static void RemoveSVGRenderer()
		{
		}

		protected static RenderTexture GetRenderTexture(SVGAsset svgAsset, Rect textureSize)
		{
			return null;
		}

		public static RenderTexture RenderSVG(SVGAsset svgAsset, Rect textureSize)
		{
			return null;
		}
	}
}
