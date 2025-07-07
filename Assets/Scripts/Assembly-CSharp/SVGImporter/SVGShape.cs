using System;
using System.Collections.Generic;
using SVGImporter.Rendering;
using UnityEngine;

namespace SVGImporter
{
	[Serializable]
	public struct SVGShape
	{
		public SVGShapeType type;

		public Vector2[] vertices;

		public int[] triangles;

		public Color32[] colors;

		public Vector2[] angles;

		public float depth;

		public Rect bounds;

		public SVGFill fill;

		public int vertexCount => 0;

		public SVGShape(Vector2[] vertices, int[] triangles, Color32[] colors, Vector2[] angles, int depth, Rect bounds, SVGFill fill)
		{
			type = default(SVGShapeType);
			this.vertices = null;
			this.triangles = null;
			this.colors = null;
			this.angles = null;
			this.depth = 0f;
			this.bounds = default(Rect);
			this.fill = null;
		}

		public void RecalculateBounds()
		{
		}

		public SVGShape Clone()
		{
			return default(SVGShape);
		}

		public static SVGShape MergeShapes(IList<SVGShape> svgShapes)
		{
			return default(SVGShape);
		}

		public static SVGShape MergeLayersToShape(IList<SVGLayer> svgLayers)
		{
			return default(SVGShape);
		}

		public static SVGShape[] MergeLayersToShapes(IList<SVGLayer> svgLayers)
		{
			return null;
		}
	}
}
