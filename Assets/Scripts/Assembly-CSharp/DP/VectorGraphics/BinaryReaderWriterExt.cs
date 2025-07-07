using System.IO;
using UnityEngine;

namespace DP.VectorGraphics
{
	public static class BinaryReaderWriterExt
	{
		public static void WriteVector2(this BinaryWriter aWriter, Vector2 aVec)
		{
		}

		public static Vector2 ReadVector2(this BinaryReader aReader)
		{
			return default(Vector2);
		}

		public static void WriteVector3(this BinaryWriter aWriter, Vector3 aVec)
		{
		}

		public static Vector3 ReadVector3(this BinaryReader aReader)
		{
			return default(Vector3);
		}

		public static void WriteColor32(this BinaryWriter aWriter, Color32 aCol)
		{
		}

		public static Color32 ReadColor32(this BinaryReader aReader)
		{
			return default(Color32);
		}
	}
}
