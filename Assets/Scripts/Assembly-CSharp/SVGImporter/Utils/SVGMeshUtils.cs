using System;
using System.Collections.Generic;
using UnityEngine;

namespace SVGImporter.Utils
{
	public class SVGMeshUtils
	{
		public enum ColorChannel
		{
			RED = 0,
			GREEN = 1,
			BLUE = 2,
			ALPHA = 3
		}

		private const float PI2 = (float)Math.PI * 2f;

		public static Vector2 lineUVScale;

		public static Vector2 lineUVOffset;

		public static Mesh Quad()
		{
			return null;
		}

		public static Mesh Quad(float size)
		{
			return null;
		}

		public static Mesh Quad(Vector2 size)
		{
			return null;
		}

		public static Mesh Quad(Vector2 size, int hSegments, int vSegments)
		{
			return null;
		}

		public static Mesh Quad(Vector2 size, int hSegments, int vSegments, Vector3 anchorOffset, Color32 color)
		{
			return null;
		}

		public static Mesh Quad(Vector2 size, int hSegments, int vSegments, Vector3 anchorOffset)
		{
			return null;
		}

		public static Mesh Circle(int circuitSegments, Matrix4x4 meshTransform, Matrix4x4 uvTransform)
		{
			return null;
		}

		public static Mesh Rectangle(Matrix4x4 meshTransform, Matrix4x4 uvTransform)
		{
			return null;
		}

		public static Mesh Rectangle()
		{
			return null;
		}

		public static Mesh Line(int tessellation, Vector3[] positions, Color32 color, float size = 1f, bool closeLine = false)
		{
			return null;
		}

		public static Mesh Line(int tessellation, Vector2[] positions, Color32 color, float size = 1f, bool closeLine = false)
		{
			return null;
		}

		public static Mesh Line(int tessellation, Vector2[] positions, Color32[] colors = null, float[] sizes = null, Vector3[] rotations = null, bool closeLine = false)
		{
			return null;
		}

		public static void ResetLineSettings()
		{
		}

		public static Mesh Line(int tessellation, Vector3[] positions, Color32[] colors = null, float[] sizes = null, Vector3[] rotations = null, bool closeLine = false)
		{
			return null;
		}

		public static bool VectorLine(Vector2[] positions, out SVGShape svgLayer, Color32 colorA, Color32 colorB, float size, float offset, ClosePathRule closeLine = ClosePathRule.NEVER)
		{
			svgLayer = default(SVGShape);
			return false;
		}

		public static void ChangeMeshUV1(Mesh mesh, Vector2 uv)
		{
		}

		public static void ChangeMeshUV2(Mesh mesh, Vector2 uv)
		{
		}

		public static void ChangeMeshUV3(Mesh mesh, Vector2 uv)
		{
		}

		public static void ChangeMeshColor(Mesh mesh, Color32 color)
		{
		}

		public static void ChangeMeshColor(Mesh mesh, ColorChannel channel, byte value)
		{
		}

		public static void ChangeMeshColor(Mesh mesh, ColorChannel channel, float value)
		{
		}

		public static void ChangeMeshColor(Mesh mesh, Color color)
		{
		}

		public static void ChengeMeshPosition(Mesh mesh, Vector3 offset)
		{
		}

		public static void ChangeMeshRotation(Mesh mesh, Quaternion rotation)
		{
		}

		public static void ChangeMeshScale(Mesh mesh, Vector3 scale)
		{
		}

		public static void ChangeMeshScale(Mesh mesh, float scale)
		{
		}

		public static void AutoWeldVertices(Mesh mesh, float threshold)
		{
		}

		public static GameObject MergeMeshes(GameObject source)
		{
			return null;
		}

		public static void Fill(Mesh source, Mesh destination)
		{
		}

		public static Mesh Clone(Mesh mesh)
		{
			return null;
		}

		public static Material CloneMaterial(Material original)
		{
			return null;
		}

		public static List<Vector3> GetEdgePoints(int[] triangles, Vector3[] positions)
		{
			return null;
		}

		public static int CalculateWindingOrder(IList<Vector3> points)
		{
			return 0;
		}

		public static int CalculateWindingOrder(IList<Vector2> points)
		{
			return 0;
		}

		public static int CalculateWindingOrder(Vector2[] points)
		{
			return 0;
		}

		public static double CalculateSignedArea(IList<Vector3> points)
		{
			return 0.0;
		}

		public static double CalculateSignedArea(Vector3[] points)
		{
			return 0.0;
		}

		public static double CalculateSignedArea(IList<Vector2> points)
		{
			return 0.0;
		}

		public static double CalculateSignedArea(Vector2[] points)
		{
			return 0.0;
		}

		public static List<int[]> BuildManifoldPoints(Vector3[] vertices, int[] triangles)
		{
			return null;
		}

		public static Edge[] BuildManifoldEdges(Vector3[] vertices, int[] triangles)
		{
			return null;
		}

		public static Edge[] BuildEdges(int vertexCount, int[] triangleArray)
		{
			return null;
		}
	}
}
