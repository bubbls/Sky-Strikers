using System.Collections.Generic;
using SVGImporter.Document;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGLineElement : SVGParentable, ISVGDrawable, ISVGElement
	{
		private SVGLength _x1;

		private SVGLength _y1;

		private SVGLength _x2;

		private SVGLength _y2;

		private AttributeList _attrList;

		private SVGPaintable _paintable;

		public AttributeList attrList => default(AttributeList);

		public SVGPaintable paintable => null;

		public SVGLength x1 => default(SVGLength);

		public SVGLength y1 => default(SVGLength);

		public SVGLength x2 => default(SVGLength);

		public SVGLength y2 => default(SVGLength);

		public SVGLineElement(Node node, SVGTransformList inheritTransformList, SVGPaintable inheritPaintable = null)
			: base(null)
		{
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
