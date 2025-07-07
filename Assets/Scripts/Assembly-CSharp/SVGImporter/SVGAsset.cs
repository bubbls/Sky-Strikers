using SVGImporter.Rendering;
using UnityEngine;
using UnityEngine.Serialization;

namespace SVGImporter
{
	public class SVGAsset : ScriptableObject
	{
		[SerializeField]
		[FormerlySerializedAs("lastTimeModified")]
		protected long _lastTimeModified;

		[FormerlySerializedAs("documentAsset")]
		[SerializeField]
		protected SVGDocumentAsset _documentAsset;

		[FormerlySerializedAs("sharedMesh")]
		[SerializeField]
		protected Mesh _sharedMesh;

		protected Mesh _runtimeMesh;

		protected Mesh _runtimeLegacyUIMesh;

		protected Material[] _runtimeMaterials;

		[FormerlySerializedAs("antialiasing")]
		[SerializeField]
		protected bool _antialiasing;

		[FormerlySerializedAs("generateCollider")]
		[SerializeField]
		protected bool _generateCollider;

		[SerializeField]
		[FormerlySerializedAs("keepSVGFile")]
		protected bool _keepSVGFile;

		[FormerlySerializedAs("ignoreSVGCanvas")]
		[SerializeField]
		protected bool _ignoreSVGCanvas;

		[FormerlySerializedAs("colliderShape")]
		[SerializeField]
		protected SVGPath[] _colliderShape;

		[SerializeField]
		[FormerlySerializedAs("format")]
		protected SVGAssetFormat _format;

		[SerializeField]
		[FormerlySerializedAs("useGradients")]
		protected SVGUseGradients _useGradients;

		[FormerlySerializedAs("meshCompression")]
		[SerializeField]
		protected SVGMeshCompression _meshCompression;

		[SerializeField]
		[FormerlySerializedAs("optimizeMesh")]
		protected bool _optimizeMesh;

		[SerializeField]
		[FormerlySerializedAs("generateNormals")]
		protected bool _generateNormals;

		[SerializeField]
		[FormerlySerializedAs("generateTangents")]
		protected bool _generateTangents;

		[SerializeField]
		[FormerlySerializedAs("scale")]
		protected float _scale;

		[FormerlySerializedAs("vpm")]
		[SerializeField]
		protected float _vpm;

		[FormerlySerializedAs("depthOffset")]
		[SerializeField]
		protected float _depthOffset;

		[FormerlySerializedAs("compressDepth")]
		[SerializeField]
		protected bool _compressDepth;

		[FormerlySerializedAs("pivotPoint")]
		[SerializeField]
		protected Vector2 _pivotPoint;

		[FormerlySerializedAs("customPivotPoint")]
		[SerializeField]
		protected bool _customPivotPoint;

		[SerializeField]
		[FormerlySerializedAs("border")]
		protected Vector4 _border;

		[FormerlySerializedAs("sliceMesh")]
		[SerializeField]
		protected bool _sliceMesh;

		protected string _svgFile;

		[FormerlySerializedAs("sharedGradients")]
		[SerializeField]
		protected CCGradient[] _sharedGradients;

		[FormerlySerializedAs("sharedShaders")]
		[SerializeField]
		protected string[] _sharedShaders;

		[FormerlySerializedAs("canvasRectangle")]
		[SerializeField]
		protected Rect _canvasRectangle;

		[FormerlySerializedAs("useLayers")]
		[SerializeField]
		protected bool _useLayers;

		[FormerlySerializedAs("layers")]
		[SerializeField]
		protected SVGLayer[] _layers;

		public Mesh sharedMesh => null;

		public bool isOpaque => false;

		public Mesh mesh => null;

		protected Mesh runtimeMesh => null;

		protected Mesh runtimeLegacyUIMesh => null;

		public Mesh sharedLegacyUIMesh => null;

		public Material sharedUIMaterial => null;

		public Material uiMaterial => null;

		public Material[] sharedMaterials => null;

		public Material[] materials => null;

		public Material[] runtimeMaterials => null;

		public bool antialiasing => false;

		public bool generateCollider => false;

		public bool keepSVGFile => false;

		public bool ignoreSVGCanvas => false;

		public SVGPath[] colliderShape => null;

		public SVGAssetFormat format => default(SVGAssetFormat);

		public SVGUseGradients useGradients => default(SVGUseGradients);

		public SVGMeshCompression meshCompression => default(SVGMeshCompression);

		public bool optimizeMesh => false;

		public bool generateNormals => false;

		public bool generateTangents => false;

		public float scale => 0f;

		public float vpm => 0f;

		public float depthOffset => 0f;

		public bool compressDepth => false;

		public Vector2 pivotPoint => default(Vector2);

		public bool customPivotPoint => false;

		public Vector4 border => default(Vector4);

		public bool sliceMesh => false;

		public string svgFile => null;

		public CCGradient[] sharedGradients => null;

		public string[] sharedShaders => null;

		public Bounds bounds => default(Bounds);

		public Rect canvasRectangle => default(Rect);

		public bool useLayers => false;

		public SVGLayer[] layers => null;

		public SVGLayer[] layersClone => null;

		public bool hasGradients => false;

		public int uiVertexCount => 0;

		public void AddReference(ISVGReference reference)
		{
		}

		public void RemoveReference(ISVGReference reference)
		{
		}

		protected Material CloneMaterial(Material original)
		{
			return null;
		}

		protected static Mesh CreateLegacyUIMesh(Mesh inputMesh)
		{
			return null;
		}

		public static SVGAsset Load(Mesh mesh, SVGImporterSettings settings = null)
		{
			return null;
		}

		public static SVGAsset Load(string svgText, SVGImporterSettings settings = null)
		{
			return null;
		}
	}
}
