using System.Collections.Generic;
using SVGImporter.Document;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPathElement : SVGParentable, ISVGDrawable, ISVGElement
	{
		private SVGPathSegList _segList;

		private AttributeList _attrList;

		private SVGPaintable _paintable;

		private static SVGPathSegTypes lastCommand;

		public SVGPathSegList segList => null;

		public AttributeList attrList => default(AttributeList);

		public SVGPaintable paintable => null;

		public SVGPathElement(Node node, SVGTransformList inheritTransformList, SVGPaintable inheritPaintable = null)
			: base(null)
		{
		}

		private void Initial()
		{
		}

		private SVGPathSegClosePath CreateSVGPathSegClosePath()
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

		private bool GetSegment(SVGPathElement svgElement, SVGPathSeg segment, List<List<Vector2>> output, List<Vector2> positionBuffer, SVGMatrix matrix)
		{
			return false;
		}
	}
}
