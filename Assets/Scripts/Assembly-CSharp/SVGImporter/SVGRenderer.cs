using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace SVGImporter
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	[AddComponentMenu("Rendering/SVG Renderer", 20)]
	[ExecuteInEditMode]
	public class SVGRenderer : UIBehaviour, ISVGShape, ISVGRenderer, ISVGReference
	{
		public enum Type
		{
			Simple = 0,
			Sliced = 1
		}

		private Type _lastType;

		[FormerlySerializedAs("type")]
		[SerializeField]
		private Type _type;

		private Rect _rectTransformRect;

		private Rect _lastRectTransformRect;

		[FormerlySerializedAs("vectorGraphics")]
		[SerializeField]
		protected SVGAsset _vectorGraphics;

		private SVGAsset _lastVectorGraphics;

		[FormerlySerializedAs("color")]
		[SerializeField]
		protected Color _color;

		private Color _lastColor;

		private Color32[] _cachedColors;

		private Vector3[] _cachedVertices;

		[FormerlySerializedAs("opaqueMaterial")]
		[SerializeField]
		protected Material _opaqueMaterial;

		private Material _lastOpaqueMaterial;

		[FormerlySerializedAs("transparentMaterial")]
		[SerializeField]
		protected Material _transparentMaterial;

		private Material _lastTransparentMaterial;

		private bool _cachedComponents;

		private MeshFilter _meshFilter;

		private MeshRenderer _meshRenderer;

		private SVGLayer[] _layers;

		private Mesh _sharedMesh;

		private Mesh _mesh;

		[SerializeField]
		[FormerlySerializedAs("sortingLayerID")]
		protected int _sortingLayerID;

		[SerializeField]
		[FormerlySerializedAs("sortingLayerName")]
		protected string _sortingLayerName;

		[FormerlySerializedAs("sortingOrder")]
		[SerializeField]
		protected int _sortingOrder;

		[FormerlySerializedAs("overrideSorter")]
		[SerializeField]
		protected bool _overrideSorter;

		[SerializeField]
		[FormerlySerializedAs("overrideSorterChildren")]
		protected bool _overrideSorterChildren;

		private Color32[] _finalColors;

		private const float epsilon = 1E-07f;

		private Vector3[] _finalVertices;

		private bool _lastUseSharedMesh;

		public Type type
		{
			get
			{
				return default(Type);
			}
			set
			{
			}
		}

		public int lastFrameChanged { get; private set; }

		public SVGAsset vectorGraphics
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Material opaqueMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material transparentMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private MeshFilter meshFilter => null;

		public MeshRenderer meshRenderer => null;

		public RectTransform rectTransform => null;

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool overrideSorter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool overrideSorterChildren
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SVGPath[] shape => null;

		private bool hasBorder => false;

		protected float pixelsPerUnit => 0f;

		private bool useLayers => false;

		private bool useSharedMesh => false;

		public bool IsVisible => false;

		public List<ISVGModify> modifiers { get; }

		public event Action<SVGAsset> OnVectorGraphicsChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<SVGLayer[], SVGAsset, bool> OnPrepareForRendering
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		private void OnWillRenderObject()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void CacheComponents()
		{
		}

		public void UpdateRenderer()
		{
		}

		private void PrepareForRendering(bool force = false)
		{
		}

		private void GenerateMesh()
		{
		}

		private void UpdateColors()
		{
		}

		private static float InverseLerp(float from, float to, float value)
		{
			return 0f;
		}

		private static float SafeDivide(float a, float b)
		{
			return 0f;
		}

		protected string BorderToString(Vector4 border)
		{
			return null;
		}

		private void UpdateSlicedMesh()
		{
		}

		internal bool AtlasContainsMaterial(Material material)
		{
			return false;
		}

		private void SwapMaterials(bool transparent = true)
		{
		}

		private void SetSharedMaterials(int subMeshCount, Material firstMaterial, Material secondMaterial)
		{
		}

		private void UpdateMaterials()
		{
		}

		public void SetAllDirty()
		{
		}

		private void EnableMeshRenderer(bool value)
		{
		}

		private void InitMesh()
		{
		}

		public void AddModifier(ISVGModify modifier)
		{
		}

		public void RemoveModifier(ISVGModify modifier)
		{
		}

		private void Clear()
		{
		}

		private void CleanMaterials()
		{
		}

		private void CleanMesh()
		{
		}

		private void CleanLayers()
		{
		}

		private void CleanCache()
		{
		}
	}
}
