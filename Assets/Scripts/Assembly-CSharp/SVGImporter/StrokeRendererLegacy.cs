using System;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter
{
	[RequireComponent(typeof(MeshRenderer))]
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter))]
	public class StrokeRendererLegacy : MonoBehaviour
	{
		[Serializable]
		public struct StrokePoint
		{
			public Vector2 position;

			public Transform transform;

			public Vector2 GetPosition()
			{
				return default(Vector2);
			}
		}

		public StrokePoint[] points;

		[Header("Line Style")]
		public StrokeLineJoin lineJoin;

		public StrokeLineCap lineCap;

		public Color32 color;

		public float width;

		public float mitterLimit;

		public float roundQuality;

		public float[] dashArray;

		public float dashOffset;

		public ClosePathRule closeLine;

		protected MeshFilter _meshFilter;

		protected MeshRenderer _meshRenderer;

		public MeshFilter meshFilter => null;

		public MeshRenderer meshRenderer => null;

		private void LateUpdate()
		{
		}

		protected virtual void RenderStroke()
		{
		}
	}
}
