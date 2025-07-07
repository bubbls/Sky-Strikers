using System.Collections.Generic;
using UnityEngine;

namespace SVGImporter.Geometry
{
	public class SVGMeshCutter
	{
		private struct MeshBuilder
		{
			private struct IntPair
			{
				public int first;

				public int second;

				public IntPair(int first, int second)
				{
					this.first = 0;
					this.second = 0;
				}
			}

			public List<Vector3> pos;

			public List<Color32> col;

			public List<Vector2> uv;

			public List<Vector2> uv2;

			public List<int> tri;

			private Dictionary<IntPair, int> map;

			private Mesh mesh;

			private Vector3[] origVertices;

			public MeshBuilder(Mesh m, Vector3[] vertices)
			{
				pos = null;
				col = null;
				uv = null;
				uv2 = null;
				tri = null;
				map = null;
				mesh = null;
				origVertices = null;
			}

			private int MergeVertex(int i)
			{
				return 0;
			}

			private static void MergeCutVertex(MeshBuilder leftSide, MeshBuilder rightSide, int i1, int i2, Vector2 origin, Vector2 direction, out int jl, out int jr)
			{
				jl = default(int);
				jr = default(int);
			}

			public void AddTri(int i1, int i2, int i3)
			{
			}

			public static void AddCutTri(MeshBuilder leftSide, MeshBuilder rightSide, int i1, int i2, int i3, Vector2 origin, Vector2 direction)
			{
			}

			public Mesh ToMesh()
			{
				return null;
			}

			private static float CutEdge(Vector3 v1, Vector3 v2, Vector2 origin, Vector2 direction)
			{
				return 0f;
			}

			public bool IsDegenerate(Vector2 origin, Vector2 direction)
			{
				return false;
			}
		}
	}
}
