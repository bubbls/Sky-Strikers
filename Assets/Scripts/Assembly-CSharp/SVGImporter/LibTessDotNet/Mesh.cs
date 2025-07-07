namespace SVGImporter.LibTessDotNet
{
	internal class Mesh
	{
		internal MeshUtils.Vertex _vHead;

		internal MeshUtils.Face _fHead;

		internal MeshUtils.Edge _eHead;

		internal MeshUtils.Edge _eHeadSym;

		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		public void Delete(MeshUtils.Edge eDel)
		{
		}

		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		public void Check()
		{
		}
	}
}
