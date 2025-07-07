using System;
using System.Collections.Generic;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGBezier
	{
		private const int maxAdaptiveBezierIteration = 200;

		private static int currentAdaptiveBezierIteration;

		private const float PI = (float)Math.PI;

		private const float PI2 = (float)Math.PI * 2f;

		public static Vector3[] QuadraticBezierCurve(int segments, Vector3 start, Vector3 handle, Vector3 end)
		{
			return null;
		}

		public static Vector2[] QuadraticBezierCurve(int segments, Vector2 start, Vector2 handle, Vector2 end)
		{
			return null;
		}

		public static Vector3[] CubicBezierCurve(int segments, Vector3 start, Vector3 handle0, Vector3 handle1, Vector3 end)
		{
			return null;
		}

		public static float ClosestPointOnCubicBezierCurve(int segments, Vector3 start, Vector3 handle0, Vector3 handle1, Vector3 end, Vector3 point, out Vector3 pointOnLine)
		{
			pointOnLine = default(Vector3);
			return 0f;
		}

		public static float ClosestPointToLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point, out Vector3 pointOnLine)
		{
			pointOnLine = default(Vector3);
			return 0f;
		}

		public static Vector2[] CubicBezierCurve(int segments, Vector2 start, Vector2 handle0, Vector2 handle1, Vector2 end)
		{
			return null;
		}

		public static List<Vector2> Optimise(List<Vector2> pointList, float precision, int startPosition = 0, int endPosition = -1)
		{
			return null;
		}

		public static Vector2[] Optimise(Vector2[] pointList, float precision, int startPosition = 0, int endPosition = -1)
		{
			return null;
		}

		public static List<int> RamerDouglasPeuckerIndex(Vector2[] pointArray, float precision, int startPosition = 0, int endPosition = -1)
		{
			return null;
		}

		protected static List<Vector2> RamerDouglasPeucker(List<Vector2> pointList, float precision, int startPosition = 0, int endPosition = -1)
		{
			return null;
		}

		private static float PointDistance(Vector2 point1, Vector2 point2)
		{
			return 0f;
		}

		private static float AngularCoefficient(Vector2 point1, Vector2 point2)
		{
			return 0f;
		}

		private static float YIntercept(Vector2 point, float angularCoef)
		{
			return 0f;
		}

		private static float PerpendicularDistance(Vector2 point, Vector2 lineStartPoint, Vector2 lineEndPoint)
		{
			return 0f;
		}

		public static float CurveLength(Vector3[] points)
		{
			return 0f;
		}

		public static float CurveLength(Vector2[] points)
		{
			return 0f;
		}

		public static SVGBounds GetLooseBounds(Vector2 start, Vector2 handle0, Vector2 handle1, Vector2 end)
		{
			return default(SVGBounds);
		}

		public static SVGBounds GetLooseBounds(Vector2 start, Vector2 handle, Vector2 end)
		{
			return default(SVGBounds);
		}

		public static List<float> GetExtremes(Vector2 start, Vector2 handle0, Vector2 handle1, Vector2 end)
		{
			return null;
		}

		public static List<Vector2> AdaptiveCubicCurve(float distanceTolerance, Vector2 start, Vector2 handle0, Vector2 handle1, Vector2 end)
		{
			return null;
		}

		private static void RecursiveBezier(List<Vector2> points, float distanceTolerance, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
		}

		public static Vector2[] GetExtremePoints(Vector2 start, Vector2 handle0, Vector2 handle1, Vector2 end)
		{
			return null;
		}

		public static float GetApproxLength(Vector2 start, Vector2 handle0, Vector2 handle1, Vector2 end)
		{
			return 0f;
		}

		public static SVGBounds GetBounds(Vector2 start, Vector2 handle0, Vector2 handle1, Vector2 end)
		{
			return default(SVGBounds);
		}

		public static Vector3[] PathControlPointGenerator(Vector3[] path)
		{
			return null;
		}

		public static Vector2[] PathControlPointGenerator(Vector2[] path)
		{
			return null;
		}

		public static Vector3 Interpolate(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		public static Vector2 Interpolate(Vector2[] points, float t)
		{
			return default(Vector2);
		}
	}
}
