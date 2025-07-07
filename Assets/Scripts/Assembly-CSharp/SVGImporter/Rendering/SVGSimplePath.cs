using System.Collections.Generic;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGSimplePath
	{
		private struct VertexData
		{
			public int shapeIndex;

			public int vertexIndex;

			public int totalIndex;

			public VertexData(int shapeIndex, int vertexIndex, int totalIndex)
			{
				this.shapeIndex = 0;
				this.vertexIndex = 0;
				this.totalIndex = 0;
			}
		}

		public static StrokeLineCap GetStrokeLineCap(SVGStrokeLineCapMethod capMethod)
		{
			return default(StrokeLineCap);
		}

		public static StrokeLineJoin GetStrokeLineJoin(SVGStrokeLineJoinMethod capMethod)
		{
			return default(StrokeLineJoin);
		}

		public static StrokeSegment[] GetSegments(List<Vector2> points)
		{
			return null;
		}

		public static Color GetStrokeColor(SVGPaintable paintable)
		{
			return default(Color);
		}

		public static List<List<Vector2>> CreateStroke(List<Vector2> inputShapes, SVGPaintable paintable, ClosePathRule closePath = ClosePathRule.NEVER)
		{
			return null;
		}

		public static List<List<Vector2>> CreateStroke(List<List<Vector2>> inputShapes, SVGPaintable paintable, ClosePathRule closePath = ClosePathRule.NEVER)
		{
			return null;
		}

		public static Mesh CreateStrokeSimple(List<List<Vector2>> inputShapes, SVGPaintable paintable, ClosePathRule closePath = ClosePathRule.NEVER)
		{
			return null;
		}

		public static bool CreateAntialiasing(List<List<Vector2>> inputShapes, out SVGShape svgShape, Color colorA, float width, ClosePathRule closePath = ClosePathRule.NEVER)
		{
			svgShape = default(SVGShape);
			return false;
		}

		public static bool CreatePolygon(List<List<Vector2>> inputShapes, SVGPaintable paintable, SVGMatrix matrix, out SVGShape layer, out SVGShape antialiasingLayer, bool isStroke = false, bool antialiasing = false)
		{
			layer = default(SVGShape);
			antialiasingLayer = default(SVGShape);
			return false;
		}

		protected static void WriteUVGradientIndexType(ref Vector2[] uv, int meshVertexCount, SVGPaintable svgPaintable)
		{
		}

		private static void UpdateMesh(Mesh mesh, SVGFill svgFill)
		{
		}

		private static Bounds GetBounds(List<Vector2> array)
		{
			return default(Bounds);
		}

		private static Rect GetRect(List<Vector2> array)
		{
			return default(Rect);
		}

		private static Rect GetRect(List<List<Vector2>> array)
		{
			return default(Rect);
		}

		private static void OffsetPositions(Bounds bounds, List<Vector2> array)
		{
		}

		protected static Vector2 GetGradientVector(SVGLength posX, SVGLength posY, Rect bounds)
		{
			return default(Vector2);
		}

		public static SVGMatrix GetFillTransform(SVGFill svgFill, Rect bounds, SVGLength[] gradientStart, SVGLength[] gradientEnd, SVGMatrix fillTransform, SVGMatrix gradientTransform)
		{
			return default(SVGMatrix);
		}

		protected static void AddInputShape(List<List<Vector2>> inputShapes)
		{
		}
	}
}
