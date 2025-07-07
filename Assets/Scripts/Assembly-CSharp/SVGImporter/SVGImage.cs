using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace SVGImporter
{
	[ExecuteInEditMode]
	[AddComponentMenu("UI/SVG Image", 21)]
	[RequireComponent(typeof(CanvasRenderer))]
	public class SVGImage : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter, ISVGRenderer, ISVGReference
	{
		public enum Type
		{
			Simple = 0,
			Sliced = 1
		}

		[SerializeField]
		[FormerlySerializedAs("vectorGraphics")]
		protected SVGAsset _vectorGraphics;

		protected SVGAsset _lastVectorGraphics;

		[SerializeField]
		private Type m_Type;

		[SerializeField]
		private bool m_PreserveAspect;

		[SerializeField]
		private bool m_UsePivot;

		private float m_EventAlphaThreshold;

		protected Material _defaultMaterial;

		protected List<ISVGModify> _modifiers;

		protected int _lastFrameChanged;

		private const float epsilon = 1E-07f;

		private int tempVBOLength;

		private UIVertex[] vertexStream;

		private Vector3[] vertices;

		private int[] triangles;

		private Vector2[] uv;

		private Vector2[] uv2;

		private Vector2[] uv3;

		private Color32[] colors;

		private Vector3[] normals;

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

		public bool preserveAspect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool usePivot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float eventAlphaThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<ISVGModify> modifiers => null;

		public int lastFrameChanged => 0;

		private bool useLayers => false;

		public bool hasBorder => false;

		public float pixelsPerUnit => 0f;

		protected Mesh sharedMesh => null;

		public override Material defaultMaterial => null;

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

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

		public void AddModifier(ISVGModify modifier)
		{
		}

		public void RemoveModifier(ISVGModify modifier)
		{
		}

		public void UpdateRenderer()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default(Vector4);
		}

		public override void SetNativeSize()
		{
		}

		protected float InverseLerp(float from, float to, float value)
		{
			return 0f;
		}

		protected float Lerp(float from, float to, float value)
		{
			return 0f;
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return false;
		}

		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return default(Vector2);
		}

		public override void SetMaterialDirty()
		{
		}

		private static float SafeDivide(float a, float b)
		{
			return 0f;
		}

		protected string BorderToString(Vector4 border)
		{
			return null;
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		protected void GetDefaultMaterial()
		{
		}

		protected void Clear()
		{
		}

		protected override void UpdateMaterial()
		{
		}
	}
}
