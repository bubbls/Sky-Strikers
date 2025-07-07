using System.Collections.Generic;
using SVGImporter.Rendering;
using UnityEngine;

namespace SVGImporter.Utils
{
	public class SVGGeomUtils
	{
		private struct Vector2Ext
		{
			private float _delta;

			private Vector2 _point;

			public float t => 0f;

			public Vector2 point => default(Vector2);

			public Vector2Ext(Vector2 point, float t)
			{
				_delta = 0f;
				_point = default(Vector2);
			}
		}

		private static LiteStack<Vector2Ext> _stack;

		private static List<Vector2Ext> _limitList;

		public static List<Vector2> RoundedRect(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p5, Vector2 p6, Vector2 p7, Vector2 p8, float r1, float r2, float angle)
		{
			return null;
		}

		public static List<Vector2> Arc(Vector2 p1, float rx, float ry, float angle, bool largeArcFlag, bool sweepFlag, Vector2 p2)
		{
			return null;
		}

		public static Vector2 TransformPoint(Vector2 point, SVGMatrix matrix)
		{
			return default(Vector2);
		}

		private static float BelongPosition(Vector2 a, Vector2 b, Vector2 c)
		{
			return 0f;
		}

		private static int NumberOfLimitForCubic(Vector2 a, Vector2 b, Vector2 c, Vector2 d)
		{
			return 0;
		}

		private static float Distance(Vector2 a, Vector2 b, Vector2 c)
		{
			return 0f;
		}

		private static Vector2 EvaluateForCubic(float t, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			return default(Vector2);
		}

		private static Vector2 EvaluateForQuadratic(float t, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			return default(Vector2);
		}

		private static List<Vector2> CubicCurve(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, int numberOfLimit, bool cubic)
		{
			return null;
		}

		public static List<Vector2> CubicCurve(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			return null;
		}

		public static List<Vector2> QuadraticCurve(Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return null;
		}

		public static bool IsWindingClockWise(List<Vector2> points)
		{
			return false;
		}

		public static bool IsWindingClockWise(Vector2[] points)
		{
			return false;
		}

		public static Vector2[] GetPathNormals(List<Vector2> points)
		{
			return null;
		}

		public static Vector2[] GetPathNormals(Vector2[] points)
		{
			return null;
		}

		public static Vector2[] OffsetVerts(Vector2[] aSegment, float scale)
		{
			return null;
		}

		public static Vector2 GetNormal(Vector2[] aSegment, int i, bool aClosed)
		{
			return default(Vector2);
		}
	}
}
