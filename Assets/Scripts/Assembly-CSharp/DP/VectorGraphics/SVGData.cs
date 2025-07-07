using System;
using UnityEngine;

namespace DP.VectorGraphics
{
	[Serializable]
	public struct SVGData
	{
		public SVGSettings Settings;

		public Vector3[] Vertices;

		public Color32[] Colors32;

		public Vector2[] Uv;

		public Vector2[] Uv2;

		public Vector3[] Normals;

		public int[][] Triangles;
	}
}
