using System.Collections.Generic;

namespace SVGImporter.Document
{
	public class Node
	{
		public Node parent;

		public List<Node> children;

		public SVGNodeName name;

		public AttributeList attributes;

		public int depth;

		public string content;

		public Node(SVGNodeName name, AttributeList attributes, int depth)
		{
		}

		public List<Node> GetNodes()
		{
			return null;
		}

		protected void GetNodesInternal(Node node, List<Node> nodes)
		{
		}
	}
}
