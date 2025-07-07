using System;
using UnityEngine;

namespace SVGImporter.Rendering
{
	[Serializable]
	public struct SVGMatrix
	{
		public float a;

		public float b;

		public float c;

		public float d;

		public float e;

		public float f;

		public static SVGMatrix identity => default(SVGMatrix);

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

		public Vector2 scale => default(Vector2);

		public float skewX => 0f;

		public float skewY => 0f;

		public float rotation => 0f;

		public SVGMatrix(float a, float b, float c, float d, float e, float f)
		{
			this.a = 0f;
			this.b = 0f;
			this.c = 0f;
			this.d = 0f;
			this.e = 0f;
			this.f = 0f;
		}

		private Vector2 DeltaTransformPoint(Vector2 point)
		{
			return default(Vector2);
		}

		public SVGMatrix Multiply(SVGMatrix secondMatrix)
		{
			return default(SVGMatrix);
		}

		public static SVGMatrix operator *(SVGMatrix left, SVGMatrix right)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix Inverse()
		{
			return default(SVGMatrix);
		}

		public SVGMatrix Scale(float scaleFactor)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix Scale(float scaleFactorX, float scaleFactorY)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix Scale(Vector2 scaleFactor)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix Rotate(float angle)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix Translate(float x, float y)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix Translate(Vector2 position)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix SkewX(float angle)
		{
			return default(SVGMatrix);
		}

		public SVGMatrix SkewY(float angle)
		{
			return default(SVGMatrix);
		}

		public Vector2 Transform(Vector2 point)
		{
			return default(Vector2);
		}

		public Vector3 Transform(Vector3 point)
		{
			return default(Vector3);
		}

		public static SVGMatrix TRS(Vector2 position, float rotation, Vector2 scale)
		{
			return default(SVGMatrix);
		}

		public Matrix4x4 ToMatrix4x4()
		{
			return default(Matrix4x4);
		}

		public void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
