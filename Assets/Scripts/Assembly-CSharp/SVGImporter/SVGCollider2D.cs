using UnityEngine;

namespace SVGImporter
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(PolygonCollider2D))]
	[AddComponentMenu("Physics 2D/SVG Collider 2D", 20)]
	[RequireComponent(typeof(SVGRenderer))]
	public class SVGCollider2D : MonoBehaviour
	{
		[Range(0f, 1f)]
		[SerializeField]
		protected float _quality;

		[SerializeField]
		protected float _offset;

		protected SVGRenderer svgRenderer;

		protected PolygonCollider2D polygonCollider2D;

		private float precision;

		public float quality
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void OnValidate()
		{
		}

		protected virtual void UpdateCollider()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void OnVectorGraphicsChanged(SVGAsset svgAsset)
		{
		}
	}
}
