using System.Collections.Generic;
using UnityEngine;

namespace moveen.utils
{
	public static class UnityEditorUtils
	{
		public static Material mat;

		public static void fillCircle2D(Vector2 position, float r)
		{
		}

		public static void fillCircle3D(Vector3 position, Vector3 dir, float r)
		{
		}

		public static void fillStripe2D(Vector2 position, float r1, float r2, int stepsCount)
		{
		}

		public static void fillStripe(float r1, float r2, int stepsCount)
		{
		}

		public static void fillArcStripe2D(Vector2 position, float r1, float r2, int stepsCount, float from, float to)
		{
		}

		public static void drawStripOnScreen(List<Vector3> steps, List<Vector3> steps2)
		{
		}

		private static void drawStrip(List<Vector3> steps, List<Vector3> steps2)
		{
		}

		public static void initMat()
		{
		}

		public static void line2D(Vector2 from, Vector2 to, float thickness)
		{
		}

		public static void diamond(Vector3 v1, Vector3 v2)
		{
		}

		public static void diamond(Vector3 v1, Quaternion rot, float r)
		{
		}

		public static void diamond()
		{
		}

		public static void diamond2(float addAngle, int steps, float rx1, float ry, float rz)
		{
		}

		public static void arrow(Vector3 v1, Vector3 v2)
		{
		}

		public static void arrow()
		{
		}

		public static void cylinder(Vector3 pos, Vector3 X, Vector3 Y, float size, int count)
		{
		}

		public static void cylinder(Vector3 pos, Vector3 X, Vector3 Y, float size, int count, float x1, float x2, float r1, float r2)
		{
		}

		public static void cylinder(Vector3 pos, Quaternion rot, float size, int count)
		{
		}

		public static void cylinder(Vector3 pos, Quaternion rot, float size, int count, float x1, float x2, float r1, float r2)
		{
		}

		public static void cylinder(int count)
		{
		}

		public static void cylinder(int count, float x1, float x2, float r1, float r2)
		{
		}

		public static void circle3d(Vector3 pos, Quaternion rot, float r, int count)
		{
		}

		public static void circle3d(int count, float r1, float r2)
		{
		}

		public static void arc3d(Vector3 pos, Quaternion rot, int count, float r, float from, float to)
		{
		}

		public static void arc3d(int count, float r, float from, float to)
		{
		}

		public static void fillArc3d(int count, float r, float from, float to)
		{
		}

		public static void removeAllChildrenImmediate(this GameObject THIS, bool undo)
		{
		}
	}
}
