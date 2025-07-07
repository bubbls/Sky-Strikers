using UnityEngine;
using moveen.utils;

namespace moveen.descs
{
	[RequireComponent(typeof(MeshRenderer))]
	[RequireComponent(typeof(MeshFilter))]
	public class MoveenSkelBezierMesh : MoveenSkelBezier
	{
		[Range(3f, 50f)]
		public int radiusSteps;

		public float radius;

		public bool unityNormalCalculation;

		public bool startCap;

		public bool finishCap;

		public bool useDifferentFinishRadius;

		public float finishRadius;

		private MeshFilter mf;

		private Vector3[] vertices;

		private Vector3[] normals;

		private Vector2[] uv;

		private int[] tri;

		[ReadOnly]
		public int trianglesCount;

		public override void updateData()
		{
		}

		public override void tick(float dt)
		{
		}

		private int fillForStep(int rIndex, int stepIndex, int curVertex)
		{
			return 0;
		}

		public virtual Vector3 displacement(Vector3 normal, int iU, int iV)
		{
			return default(Vector3);
		}
	}
}
