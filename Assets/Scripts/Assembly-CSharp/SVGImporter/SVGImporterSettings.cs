using UnityEngine;

namespace SVGImporter
{
	public class SVGImporterSettings : ScriptableObject
	{
		private static SVGImporterSettings _instance;

		protected static string _version;

		public SVGAssetFormat defaultSVGFormat;

		public SVGUseGradients defaultUseGradients;

		public bool defaultAntialiasing;

		public float defaultAntialiasingWidth;

		public SVGMeshCompression defaultMeshCompression;

		public int defaultVerticesPerMeter;

		public float defaultScale;

		public float defaultDepthOffset;

		public bool defaultCompressDepth;

		public bool defaultCustomPivotPoint;

		public Vector2 defaultPivotPoint;

		public bool defaultGenerateCollider;

		public bool defaultKeepSVGFile;

		public bool defaultUseLayers;

		public bool defaultIgnoreSVGCanvas;

		public bool defaultOptimizeMesh;

		public bool defaultGenerateNormals;

		public bool defaultGenerateTangents;

		public Texture2D defaultSVGIcon;

		public bool ignoreImportExceptions;

		public SVGMaterials SVGMaterials;

		public static SVGImporterSettings Get => null;

		public static string version => null;

		public static void UpdateAntialiasing()
		{
		}
	}
}
