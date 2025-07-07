using System.Collections.Generic;
using SVGImporter.Document;
using SVGImporter.Rendering;
using UnityEngine;

namespace SVGImporter
{
	public class SVGAssetImport
	{
		public static SVGAtlasData atlasData;

		public static List<SVGError> errors;

		protected static bool _importingSVG;

		public static SVGUseGradients useGradients;

		public static bool antialiasing;

		public static float vpm;

		public static Vector2 pivotPoint;

		public static bool ignoreSVGCanvas;

		public static float meshScale;

		public static Vector4 border;

		public static bool sliceMesh;

		public static float minDepthOffset;

		public static SVGAssetFormat format;

		public static bool compressDepth;

		private string _SVGFile;

		private Texture2D _texture;

		private SVGGraphics _graphics;

		private SVGDocument _svgDocument;

		public static bool importingSVG => false;

		public SVGAssetImport(string svgFile, float vertexPerMeter = 1000f)
		{
		}

		private void CreateEmptySVGDocument()
		{
		}

		public static void Clear()
		{
		}

		public void NewSVGFile(string svgFile)
		{
		}

		public Texture2D GetTexture()
		{
			return null;
		}

		public Texture2D CloneTexture(Texture2D texture)
		{
			return null;
		}
	}
}
