using System;
using System.Collections.Generic;
using SVGImporter.Rendering;
using UnityEngine;

namespace SVGImporter
{
	[ExecuteInEditMode]
	public class SVGAtlas : MonoBehaviour
	{
		private bool _atlasHasChanged;

		private static bool _beingDestroyed;

		private static Texture2D _whiteTexture;

		private static Texture2D _gradientShapeTexture;

		public static int _gradientShapeTextureSize;

		private SVGAtlasData _atlasData;

		private Material _ui;

		public Material _uiAntialiased;

		private Material _opaqueSolid;

		private Material _transparentSolid;

		private Material _transparentSolidAntialiased;

		private Material _opaqueGradient;

		private Material _transparentGradient;

		private Material _transparentGradientAntialiased;

		public List<Texture2D> atlasTextures;

		public List<Material> materials;

		public const int DefaultGradientWidth = 128;

		public const int DefaultGradientHeight = 4;

		public const int DefaultAtlasTextureWidth = 512;

		public const int DefaultAtlasTextureHeight = 512;

		private const int AtlasIndex = 0;

		public int gradientWidth;

		public int gradientHeight;

		public int atlasTextureWidth;

		public int atlasTextureHeight;

		protected static SVGAtlas _Instance;

		private const int pixelOffset = 1;

		private const float PI2 = (float)Math.PI * 2f;

		private const string GradientColorKey = "_GradientColor";

		private const string GradientShapeKey = "_GradientShape";

		private const string ParamsKey = "_Params";

		public bool atlasHasChanged => false;

		public static bool beingDestroyed => false;

		public static Texture2D whiteTexture => null;

		public static Texture2D gradientShapeTexture => null;

		public static int gradientShapeTextureSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SVGAtlasData atlasData => null;

		public Material ui => null;

		public Material uiAntialiased => null;

		public Material opaqueSolid => null;

		public Material transparentSolid => null;

		public Material transparentSolidAntialiased => null;

		public Material opaqueGradient => null;

		public Material transparentGradient => null;

		public Material transparentGradientAntialiased => null;

		public static SVGAtlas Instance => null;

		public int imagePerRow => 0;

		public Vector4 textureParams => default(Vector4);

		public static void ClearGradientShapeTexture()
		{
		}

		public void UpdateMaterialProperties(Material material)
		{
		}

		protected void Awake()
		{
		}

		public void OnPreRender()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void AddFakeCamera()
		{
		}

		public void OnAtlasPreRender(Camera camera = null)
		{
		}

		public bool ContainsMaterial(Material material)
		{
			return false;
		}

		private void UpdateMaterialList()
		{
		}

		public void UpdateGradientList()
		{
		}

		public void ClearAll()
		{
		}

		protected void Init()
		{
		}

		public static void RenderGradient(Texture2D texture, CCGradient gradient, int x, int y, int gradientWidth, int gradientHeight)
		{
		}

		public bool GetCoords(out int x, out int y, int imageIndex)
		{
			x = default(int);
			y = default(int);
			return false;
		}

		public static void GetCoords(out int x, out int y, int imageIndex, int gradientWidth, int gradientHeight, int atlasTextureWidth, int atlasTextureHeight)
		{
			x = default(int);
			y = default(int);
		}

		public Texture CreateAtlasTexture(int index, int width, int height)
		{
			return null;
		}

		public static Texture2D CreateTexture(int width, int height)
		{
			return null;
		}

		public CCGradient AddGradient(CCGradient gradient)
		{
			return null;
		}

		public bool RemoveGradient(CCGradient gradient)
		{
			return false;
		}

		public CCGradient GetGradient(CCGradient gradient)
		{
			return null;
		}

		public bool HasGradient(CCGradient gradient)
		{
			return false;
		}

		public void RebuildAtlas()
		{
		}

		public static Texture2D GenerateGradientAtlasTexture(CCGradient[] gradients, int gradientWidth, int gradientHeight)
		{
			return null;
		}

		public static Texture2D GenerateGradientShapeTexture(int textureSize)
		{
			return null;
		}

		public static Texture2D GenerateWhiteTexture()
		{
			return null;
		}

		public Material GetMaterial(SVGFill fill)
		{
			return null;
		}

		protected Material GetGradientMaterial(SVGFill fill)
		{
			return null;
		}

		protected Material GetColorMaterial(SVGFill fill)
		{
			return null;
		}

		protected string GetMegaBytes(int bits)
		{
			return null;
		}

		public void ClearAllData()
		{
		}

		public void ClearMaterials()
		{
		}

		public void ClearAtlasTextures()
		{
		}

		private static void DestroyObjectInternal(UnityEngine.Object target)
		{
		}

		internal static Camera[] GetAllCameras()
		{
			return null;
		}

		internal static void AddComponent<T>(Component component) where T : MonoBehaviour
		{
		}

		public static void AssignMaterialGradients(Material material, Texture2D gradientAtlas, Texture2D gradientShape, int gradientWidth, int gradientHeight)
		{
		}

		public static void AssignMaterialGradients(Material[] materials, Texture2D gradientAtlas, Texture2D gradientShape, int gradientWidth, int gradientHeight)
		{
		}

		public Material GetTransparentMaterial(bool antialiasing, bool hasGradients)
		{
			return null;
		}

		public Material GetOpaqueMaterial(bool hasGradients)
		{
			return null;
		}
	}
}
