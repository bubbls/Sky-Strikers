using System.Collections.Generic;
using SVGImporter.Document;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPolygonElement : SVGParentable, ISVGDrawable, ISVGElement
	{
		private List<Vector2> _listPoints;

		private AttributeList _attrList;

		private SVGPaintable _paintable;

		public AttributeList attrList => default(AttributeList);

		public SVGPaintable paintable => null;

		public List<Vector2> listPoints => null;

		public SVGPolygonElement(Node node, SVGTransformList inheritTransformList, SVGPaintable inheritPaintable = null)
			: base(null)
		{
		}

		private List<Vector2> ExtractPoints(string inputText)
		{
			return null;
		}

		public void BeforeRender(SVGTransformList transformList)
		{
		}

		public List<List<Vector2>> GetPath()
		{
			return null;
		}

		public List<List<Vector2>> GetClipPath()
		{
			return null;
		}

		public void Render()
		{
		}
	}
}
