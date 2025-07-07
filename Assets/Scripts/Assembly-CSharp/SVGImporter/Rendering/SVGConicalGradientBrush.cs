using System.Collections.Generic;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGConicalGradientBrush
	{
		private SVGConicalGradientElement _conicalGradElement;

		private SVGLength _cx;

		private SVGLength _cy;

		private SVGLength _r;

		private List<Color> _stopColorList;

		private List<float> _stopOffsetList;

		protected bool _alphaBlended;

		protected SVGFill _fill;

		protected SVGMatrix _gradientTransform;

		protected SVGMatrix _transform;

		protected Rect _viewport;

		public bool alphaBlended => false;

		public SVGFill fill => null;

		public SVGConicalGradientBrush(SVGConicalGradientElement conicalGradElement)
		{
		}

		public SVGConicalGradientBrush(SVGConicalGradientElement conicalGradElement, Rect bounds, SVGMatrix matrix, Rect viewport)
		{
		}

		protected Color GetColor(SVGColor svgColor)
		{
			return default(Color);
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
	}
}
