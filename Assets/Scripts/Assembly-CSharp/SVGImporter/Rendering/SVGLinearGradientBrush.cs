using System.Collections.Generic;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGLinearGradientBrush
	{
		private SVGLinearGradientElement _linearGradElement;

		private SVGLength _x1;

		private SVGLength _y1;

		private SVGLength _x2;

		private SVGLength _y2;

		private List<Color> _stopColorList;

		private List<float> _stopOffsetList;

		protected bool _alphaBlended;

		protected SVGFill _fill;

		protected SVGMatrix _gradientTransform;

		protected SVGMatrix _transform;

		protected Rect _viewport;

		public bool alphaBlended => false;

		public SVGFill fill => null;

		public SVGLinearGradientBrush(SVGLinearGradientElement linearGradElement)
		{
		}

		public SVGLinearGradientBrush(SVGLinearGradientElement linearGradElement, Rect bounds, SVGMatrix matrix, Rect viewport)
		{
		}

		private void Initialize()
		{
		}

		private void CreateFill()
		{
		}

		private void CreateFill(Rect bounds)
		{
		}

		public CCGradient ParseGradientColors()
		{
			return null;
		}

		private void GetStopList()
		{
		}

		protected Color GetColor(SVGColor svgColor)
		{
			return default(Color);
		}
	}
}
