using System.IO;

namespace DP.VectorGraphics
{
	public static class SVGSerializer
	{
		private enum EChunkID : byte
		{
			End = 0,
			Normals = 1,
			Colors = 2,
			UV = 3,
			UV2 = 4,
			Triangles = 5,
			Settings = 6
		}

		private const uint magic = 1752393037u;

		private const int version = 1;

		public static byte[] SerializeMesh(SVGData aSvg)
		{
			return null;
		}

		public static void SerializeMesh(MemoryStream aStream, SVGData aSvg)
		{
		}

		public static void SerializeMesh(BinaryWriter writer, SVGData svg)
		{
		}

		public static SVGData DeserializeMesh(byte[] aData)
		{
			return default(SVGData);
		}

		public static SVGData DeserializeMesh(MemoryStream aStream)
		{
			return default(SVGData);
		}

		public static SVGData DeserializeMesh(BinaryReader aReader)
		{
			return default(SVGData);
		}
	}
}
