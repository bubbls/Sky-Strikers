using System.Collections.Generic;
using SVGImporter.Rendering;

namespace SVGImporter.Document
{
	public class SVGElement : SVGParentable, ISVGDrawable
	{
		protected string _name;

		private AttributeList _attrList;

		private List<object> _elementList;

		private SVGParser _xmlImp;

		private SVGPaintable _paintable;

		protected bool _rootElement;

		private SVGMatrix _cachedViewBoxTransform;

		private bool cachedViewBox;

		public string name => null;

		public AttributeList attributeList => default(AttributeList);

		public List<object> elementList => null;

		public SVGPaintable paintable => null;

		public bool rootElement => false;

		public SVGElement(SVGParser xmlImp, SVGTransformList inheritTransformList, SVGPaintable inheritPaintable, bool root = false)
			: base(null)
		{
		}

		protected void Init()
		{
		}

		private void GetElementList()
		{
		}

		public void BeforeRender(SVGTransformList transformList)
		{
		}

		public void Render()
		{
		}

		public SVGMatrix ViewBoxTransform()
		{
			return default(SVGMatrix);
		}
	}
}
