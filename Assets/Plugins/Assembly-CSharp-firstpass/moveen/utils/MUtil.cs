using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace moveen.utils
{
	public static class MUtil
	{
		private static bool UNITY_EVENTS_LOG;

		private static string lastString;

		private static bool repeatShowed;

		private static readonly Dictionary<Type, Dictionary<Type, List<FieldInfo>>> fieldByAttribute;

		public static void logEvent(object component, string eventName, bool simple = false)
		{
		}

		public static void log(object component, string eventName, bool simple = false, string prefix = "")
		{
		}

		public static void log(string console, string s)
		{
		}

		private static string composeHierarchyPath(GameObject go)
		{
			return null;
		}

		public static Quaternion toAngleAxis(float angle, Vector3 axis)
		{
			return default(Quaternion);
		}

		public static float circleCurve(float progress)
		{
			return 0f;
		}

		public static Quaternion qToAxes(Vector3 X, Vector3 Y, Vector3 Z)
		{
			return default(Quaternion);
		}

		public static Quaternion qToAxes(Vector3 X, Vector3 Y)
		{
			return default(Quaternion);
		}

		public static Quaternion qToAxesXY(Vector3 X, Vector3 Y)
		{
			return default(Quaternion);
		}

		public static Quaternion qToAxesYX(Vector3 Y, Vector3 X)
		{
			return default(Quaternion);
		}

		public static Quaternion qToAxesXZ(Vector3 X, Vector3 Z)
		{
			return default(Quaternion);
		}

		public static Quaternion qToAxesZY(Vector3 Z, Vector3 Y)
		{
			return default(Quaternion);
		}

		public static Quaternion qToAxes(float xx, float xy, float xz, float yx, float yy, float yz, float zx, float zy, float zz)
		{
			return default(Quaternion);
		}

		public static Quaternion matrix2quaternion(Vector3 X, Vector3 Y, Vector3 Z)
		{
			return default(Quaternion);
		}

		public static Quaternion matrix2quaternion(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			return default(Quaternion);
		}

		public static Vector3 torqueFromQuaternions(Quaternion currentRot, Quaternion wantedRot, Vector3 currentRotSpeed, float angleToSpeed, float speedDifToAccel, float dt)
		{
			return default(Vector3);
		}

		public static Quaternion quaternionFromTorque(Vector3 angular)
		{
			return default(Quaternion);
		}

		public static void madeCount<T>(List<T> tt, int needed) where T : new()
		{
		}

		public static void madeCount<T>(List<T> tt, int needed, T t)
		{
		}

		public static List<FieldInfo> getFieldsWhereAttributes(Type type, Type attributeType)
		{
			return null;
		}

		private static List<FieldInfo> extractFields(Type type, Type attributeType)
		{
			return null;
		}
	}
}
