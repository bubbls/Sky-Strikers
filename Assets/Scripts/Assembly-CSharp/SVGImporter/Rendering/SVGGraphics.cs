using System.Collections.Generic;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGGraphics
	{
		public static List<SVGPath> paths;

		public static List<SVGLayer> layers;

		protected static float _vpm;

		public static float _roundQuality;

		private static float _vertexPerMeter;

		private static bool _antialiasing;

		private SVGStrokeLineCapMethod _strokeLineCap;

		private SVGStrokeLineJoinMethod _strokeLineJoin;

		public static float vpm => 0f;

		public static float roundQuality => 0f;

		public static float vertexPerMeter => 0f;

		public static bool antialiasing => false;

		public SVGStrokeLineCapMethod strokeLineCap => default(SVGStrokeLineCapMethod);

		public SVGStrokeLineJoinMethod strokeLineJoin => default(SVGStrokeLineJoinMethod);

		public static void AddLayer(SVGLayer layer)
		{
		}

		public static void Create(ISVGElement svgElement, string defaultName = null, ClosePathRule closePathRule = ClosePathRule.ALWAYS)
		{
		}

		public static void CorrectSVGLayers(List<SVGLayer> layers, Rect viewport, SVGAsset asset, out Vector2 offset)
		{
			offset = default(Vector2);
		}

		protected static void CorrectSVGLayerShape(SVGShape[] shapes)
		{
		}

		public static SVGShape[] GetShapes(List<List<Vector2>> inputShapes, SVGPaintable paintable, SVGMatrix matrix, bool isStroke = false)
		{
			return null;
		}

		public static void Clear()
		{
		}

		public static void Init()
		{
		}

		public SVGGraphics(float vertexPerMeter = 1000f, bool antialiasing = false)
		{
		}

		public void SetStrokeLineCap(SVGStrokeLineCapMethod strokeLineCap)
		{
		}

		public void SetStrokeLineJoin(SVGStrokeLineJoinMethod strokeLineJoin)
		{
		}

		public bool GetThickLine(Vector2 p1, Vector2 p2, float width, ref Vector2 rp1, ref Vector2 rp2, ref Vector2 rp3, ref Vector2 rp4)
		{
			return false;
		}

		public Vector2 GetCrossPoint(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			return default(Vector2);
		}

		public float AngleBetween2Vector(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			return 0f;
		}
	}
}
