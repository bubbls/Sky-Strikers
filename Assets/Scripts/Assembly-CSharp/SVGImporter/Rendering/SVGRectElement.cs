using System.Collections.Generic;
using SVGImporter.Document;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGRectElement : SVGParentable, ISVGDrawable, ISVGElement
	{
		private SVGLength _x;

		private SVGLength _y;

		private SVGLength _width;

		private SVGLength _height;

		private SVGLength _rx;

		private SVGLength _ry;

		private AttributeList _attrList;

		private SVGPaintable _paintable;

		public AttributeList attrList => default(AttributeList);

		public SVGPaintable paintable => null;

		public SVGLength x => default(SVGLength);

		public SVGLength y => default(SVGLength);

		public SVGLength width => default(SVGLength);

		public SVGLength height => default(SVGLength);

		public SVGLength rx => default(SVGLength);

		public SVGLength ry => default(SVGLength);

		public SVGRectElement(Node node, SVGTransformList inheritTransformList, SVGPaintable inheritPaintable = null)
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
