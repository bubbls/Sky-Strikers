using System.Collections.Generic;
using SVGImporter.Rendering;

namespace SVGImporter.Document
{
	public class SVGParser : SmallXmlParser.IContentHandler
	{
		public static Dictionary<string, Node> _defs;

		private SmallXmlParser _parser;

		private int _currentDepth;

		private Node _lastParent;

		private static string STYLE_BLOCK;

		public List<Node> nodes;

		private int idx;

		private static List<SVGNodeName> dontPutInNodes;

		public Node node => null;

		public bool isEOF => false;

		public SVGParser()
		{
		}

		public static void Clear()
		{
		}

		public static void Init()
		{
		}

		public SVGParser(string text)
		{
		}

		public void AddNode(Node node)
		{
		}

		public bool Next()
		{
			return false;
		}

		public void OnStartParsing(SmallXmlParser parser)
		{
		}

		private void DontPutInNodesAdd(Node node)
		{
		}

		private void DontPutInNodesRemove(Node node)
		{
		}

		public void OnNode(Node node)
		{
		}

		public void OnInlineElement(string name, AttributeList attrs)
		{
		}

		public void OnStartElement(string name, AttributeList attrs)
		{
		}

		public void OnEndElement(string name)
		{
		}

		public bool IsInlineElement(Node node)
		{
			return false;
		}

		public void OnStyleElement(string name, AttributeList attrs, string style)
		{
		}

		public void GetElementList(List<object> elementList, SVGPaintable paintable, SVGTransformList summaryTransformList)
		{
		}

		protected void ResolveGradientLinks()
		{
		}

		private static void MergeNodeAttributes(Node source, Node target)
		{
		}

		private static SVGNodeName Lookup(string name)
		{
			return default(SVGNodeName);
		}
	}
}
