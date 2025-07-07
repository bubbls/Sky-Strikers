using System;
using System.Collections.Generic;
using UnityEngine;

namespace moveen.utils
{
	public static class ExtensionMethods
	{
		public static TValue getOrPut<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> defaultValueProvider)
		{
			return default(TValue);
		}

		public static Vector3 limit(this Vector3 THIS, float max)
		{
			return default(Vector3);
		}

		public static Vector3 minRadius(this Vector3 THIS, float max)
		{
			return default(Vector3);
		}

		public static Vector3 clamp(this Vector3 THIS, float min, float max)
		{
			return default(Vector3);
		}

		public static Vector3 clampAround(this Vector3 THIS, Vector3 center, float min, float max)
		{
			return default(Vector3);
		}

		public static Vector3 limit(this Vector3 THIS, Vector3 center, float max)
		{
			return default(Vector3);
		}

		public static Vector3 getXForHorizontalAxis(this Vector3 THIS, Vector3 normalizedAxis)
		{
			return default(Vector3);
		}

		public static Vector3 getYForHorizontalAxis(this Vector3 THIS, Vector3 normalizedAxis)
		{
			return default(Vector3);
		}

		public static Vector3 getXForVerticalAxis(this Vector3 THIS, Vector3 normal)
		{
			return default(Vector3);
		}

		public static Vector3 getYForVerticalAxis(this Vector3 THIS, Vector3 normal)
		{
			return default(Vector3);
		}

		public static Vector3 normalTo(this Vector3 THIS, Vector3 normalizedAxis)
		{
			return default(Vector3);
		}

		public static Vector2 getXy(this Vector3 v3)
		{
			return default(Vector2);
		}

		public static Vector2 getXz(this Vector3 v3)
		{
			return default(Vector2);
		}

		public static Vector3 withY(this Vector2 v2, float y)
		{
			return default(Vector3);
		}

		public static Vector3 withZ(this Vector2 v2, float z)
		{
			return default(Vector3);
		}

		public static Vector3 add(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static Vector3 add(this Vector3 a, float x, float y, float z)
		{
			return default(Vector3);
		}

		public static Vector3 sub(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static Vector3 sub(this Vector3 a, float x, float y, float z)
		{
			return default(Vector3);
		}

		public static float dot(this Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static Vector3 normalized(this Vector3 a)
		{
			return default(Vector3);
		}

		public static Vector3 normalized(this Vector3 a, float newLen)
		{
			return default(Vector3);
		}

		public static float length(this Vector3 a)
		{
			return 0f;
		}

		public static Vector3 withSetX(this Vector3 a, float value)
		{
			return default(Vector3);
		}

		public static Vector3 withSetY(this Vector3 a, float value)
		{
			return default(Vector3);
		}

		public static Vector3 withSetZ(this Vector3 a, float value)
		{
			return default(Vector3);
		}

		public static float scalarProduct(this Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static Vector3 mul(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static Vector3 mul(this Vector3 a, float x, float y, float z)
		{
			return default(Vector3);
		}

		public static Vector3 pow(this Vector3 a, float x, float y, float z)
		{
			return default(Vector3);
		}

		public static Vector3 mul(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		public static Vector3 div(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		public static Vector3 div(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static Vector3 crossProduct(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static float dist(this Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static Vector3 mix(this Vector3 a, Vector3 b, float progress)
		{
			return default(Vector3);
		}

		public static void setTranslation(this Matrix4x4 from, Vector3 tr)
		{
		}

		public static T car<T>(this List<T> list)
		{
			return default(T);
		}

		public static T cadr<T>(this List<T> list)
		{
			return default(T);
		}

		public static Quaternion ln(this Quaternion THIS)
		{
			return default(Quaternion);
		}

		public static Quaternion exp(this Quaternion THIS)
		{
			return default(Quaternion);
		}

		public static Quaternion pow(this Quaternion THIS, float n)
		{
			return default(Quaternion);
		}

		public static Quaternion rotSubDeprecated(this Quaternion THIS, Quaternion from)
		{
			return default(Quaternion);
		}

		public static Quaternion rotSub(this Quaternion THIS, Quaternion from)
		{
			return default(Quaternion);
		}

		public static Quaternion mul(this Quaternion THIS, float scale)
		{
			return default(Quaternion);
		}

		public static Quaternion normalizeWithFixedW(this Quaternion THIS)
		{
			return default(Quaternion);
		}

		public static Quaternion normalizeWithFixedW(this Quaternion THIS, float w)
		{
			return default(Quaternion);
		}

		public static Quaternion withSetW(this Quaternion THIS, float w)
		{
			return default(Quaternion);
		}

		public static Quaternion conjug(this Quaternion THIS)
		{
			return default(Quaternion);
		}

		public static Quaternion sub(this Quaternion THIS, Quaternion b)
		{
			return default(Quaternion);
		}

		public static Quaternion add(this Quaternion THIS, Quaternion b)
		{
			return default(Quaternion);
		}

		public static Quaternion mix(this Quaternion a, Quaternion b, float progress)
		{
			return default(Quaternion);
		}

		public static Vector3 imaginary(this Quaternion q)
		{
			return default(Vector3);
		}

		public static Vector3 rotate(this Quaternion THIS, Vector3 vector)
		{
			return default(Vector3);
		}

		public static float magnitude(this Quaternion q)
		{
			return 0f;
		}

		public static float norm(this Quaternion q)
		{
			return 0f;
		}

		public static Quaternion normalized(this Quaternion q)
		{
			return default(Quaternion);
		}

		public static Quaternion nlerp(this Quaternion from, Quaternion to, float blend)
		{
			return default(Quaternion);
		}

		public static Quaternion mul(this Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		public static void fillMatrix4(this Quaternion q, Matrix4x4 target)
		{
		}
	}
}
