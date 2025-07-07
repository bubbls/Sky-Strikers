using System.Collections.Generic;
using SVGImporter.ClipperLib;
using UnityEngine;

namespace SVGImporter.Utils
{
	public class SVGGeom
	{
		private const int decimalPointInt = 1000;

		private const float decimalPointFloat = 0.001f;

		public static List<IntPoint> ConvertFloatToInt(List<Vector2> polygon)
		{
			return null;
		}

		public static List<Vector2> ConvertIntToFloat(List<IntPoint> polygonInt)
		{
			return null;
		}

		public static List<List<Vector2>> SimplifyPolygon(List<Vector2> polygon, PolyFillType polyFillType = PolyFillType.pftNonZero)
		{
			return null;
		}

		public static List<List<Vector2>> SimplifyPolygons(List<List<Vector2>> polygon, PolyFillType polyFillType = PolyFillType.pftNonZero)
		{
			return null;
		}

		public static List<List<Vector2>> MergePolygon(List<List<Vector2>> polygon)
		{
			return null;
		}

		public static List<List<IntPoint>> MergePolygon(List<List<IntPoint>> polygonA, List<IntPoint> polygonB)
		{
			return null;
		}

		public static List<List<Vector2>> ClipPolygon(List<List<Vector2>> polygon, List<List<Vector2>> clipPath)
		{
			return null;
		}

		public static List<List<IntPoint>> ClipPolygon(List<IntPoint> polygon, List<IntPoint> clipPath)
		{
			return null;
		}

		public static List<List<IntPoint>> ClipPolygon(List<List<IntPoint>> polygons, List<IntPoint> clipPath)
		{
			return null;
		}

		public static List<List<IntPoint>> ClipPolygon(List<List<IntPoint>> polygons, List<List<IntPoint>> clipPaths)
		{
			return null;
		}
	}
}
