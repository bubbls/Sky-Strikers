using System.Collections.Generic;
using SVGImporter.Document;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGCircleElement : SVGParentable, ISVGDrawable, ISVGElement
	{
		private SVGLength _cx;

		private SVGLength _cy;

		private SVGLength _r;

		private AttributeList _attrList;

		private SVGPaintable _paintable;

		private const float circleConstant = 0.55191505f;

		public AttributeList attrList => default(AttributeList);

		public SVGPaintable paintable => null;

		public SVGLength cx => default(SVGLength);

		public SVGLength cy => default(SVGLength);

		public SVGLength r => default(SVGLength);

		public SVGCircleElement(Node node, SVGTransformList inheritTransformList, SVGPaintable inheritPaintable = null)
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

		public static List<Vector2> Circle(float x0, float y0, float radius, SVGMatrix matrix)
		{
			return null;
		}
	}
}
