using UnityEngine;

namespace SVGImporter.Geometry
{
	public class SVGMesh
	{
		public static bool CombineMeshes(SVGLayer[] layers, Mesh mesh, out Shader[] shaders, SVGUseGradients useGradients = SVGUseGradients.Always, SVGAssetFormat format = SVGAssetFormat.Transparent, bool compressDepth = true, bool antialiased = false)
		{
			shaders = null;
			return false;
		}
	}
}
