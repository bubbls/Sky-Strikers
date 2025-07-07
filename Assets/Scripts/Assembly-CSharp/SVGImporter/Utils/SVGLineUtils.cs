using System.Collections.Generic;
using UnityEngine;

namespace SVGImporter.Utils
{
	public class SVGLineUtils
	{
		public static List<Vector2> Stroke(StrokeSegment[] segments, float thickness, Color32 color, StrokeLineJoin lineJoin, StrokeLineCap lineCap, float miterLimit = 4f, ClosePathRule closeLine = ClosePathRule.NEVER, float roundQuality = 10f)
		{
			return null;
		}

		public static Mesh StrokeMesh(StrokeSegment[] segments, float thickness, Color32 color, StrokeLineJoin lineJoin, StrokeLineCap lineCap, float miterLimit = 4f, float[] dashArray = null, float dashOffset = 0f, ClosePathRule closeLine = ClosePathRule.NEVER, float roundQuality = 10f)
		{
			return null;
		}

		public static List<List<Vector2>> StrokeShape(List<StrokeSegment[]> segments, float thickness, Color32 color, StrokeLineJoin lineJoin, StrokeLineCap lineCap, float miterLimit = 4f, float[] dashArray = null, float dashOffset = 0f, ClosePathRule closeLine = ClosePathRule.NEVER, float roundQuality = 10f)
		{
			return null;
		}

		protected static List<StrokeSegment[]> CreateDashedStroke(StrokeSegment[] segments, float[] dashArray, float dashOffset, ref ClosePathRule closeLine)
		{
			return null;
		}

		protected static void ProcessDashArray(ref float[] dashArray, out bool useDash)
		{
			useDash = default(bool);
		}

		public static void TesselateStroke(List<List<Vector2>> inputShapes, Color32 color, out List<List<Vector2>> simplifiedShapes, out Vector3[] vertices, out int[] triangles, out Color32[] colors32)
		{
			simplifiedShapes = null;
			vertices = null;
			triangles = null;
			colors32 = null;
		}

		public static Mesh TessellateStroke(List<List<Vector2>> inputShapes, Color32 color)
		{
			return null;
		}

		public static float DeltaAngleRad(float current, float target)
		{
			return 0f;
		}
	}
}
