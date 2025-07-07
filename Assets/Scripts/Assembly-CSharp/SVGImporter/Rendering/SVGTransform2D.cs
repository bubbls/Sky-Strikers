using System;
using UnityEngine;

namespace SVGImporter.Rendering
{
	[Serializable]
	public class SVGTransform2D : ICloneable
	{
		[SerializeField]
		protected Vector2 _position;

		[SerializeField]
		protected float _rotation;

		[SerializeField]
		protected Vector2 _scale;

		[HideInInspector]
		public Vector2 position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 scale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Matrix4x4 matrix4x4 => default(Matrix4x4);

		public SVGMatrix matrix => default(SVGMatrix);

		public SVGTransform2D()
		{
		}

		public SVGTransform2D(Vector2 position, float rotation, Vector2 scale)
		{
		}

		public SVGTransform2D(SVGTransform2D transform)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void SetTransform(SVGTransform2D transform)
		{
		}

		public void Reset()
		{
		}

		public void TRS(Vector2 position, float rotation, Vector2 scale)
		{
		}

		public bool Compare(SVGTransform2D transform)
		{
			return false;
		}

		public static SVGTransform2D DecomposeMatrix(Matrix4x4 matrix)
		{
			return null;
		}
	}
}
