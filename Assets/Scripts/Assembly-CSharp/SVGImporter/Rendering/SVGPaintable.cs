using System;
using System.Collections.Generic;
using SVGImporter.Document;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Rendering
{
	[Serializable]
	public class SVGPaintable
	{
		private Rect _viewport;

		private SVGVisibility _visibility;

		private SVGDisplay _display;

		private SVGOverflow _overflow;

		private SVGClipPathUnits _clipPathUnits;

		private SVGClipRule _clipRule;

		private float _opacity;

		private float _fillOpacity;

		private float _strokeOpacity;

		private SVGColor? _fillColor;

		private SVGColor? _strokeColor;

		private SVGLength _strokeWidth;

		private SVGLength _miterLimit;

		private float[] _dashArray;

		private SVGLength _dashOfset;

		private bool isStrokeWidth;

		private SVGStrokeLineCapMethod _strokeLineCap;

		private SVGStrokeLineJoinMethod _strokeLineJoin;

		private SVGFillRule _fillRule;

		private Dictionary<string, Dictionary<string, string>> _cssStyle;

		private List<List<Vector2>> _clipPathList;

		private Dictionary<string, SVGLinearGradientElement> _linearGradList;

		private Dictionary<string, SVGRadialGradientElement> _radialGradList;

		private Dictionary<string, SVGConicalGradientElement> _conicalGradList;

		private string _gradientID;

		public SVGFill svgFill;

		public Rect viewport => default(Rect);

		public SVGVisibility visibility => default(SVGVisibility);

		public SVGDisplay display => default(SVGDisplay);

		public SVGOverflow overflow => default(SVGOverflow);

		public SVGClipPathUnits clipPathUnits => default(SVGClipPathUnits);

		public SVGClipRule clipRule => default(SVGClipRule);

		public SVGColor? fillColor => null;

		public SVGColor? strokeColor => null;

		public float opacity => 0f;

		public float fillOpacity => 0f;

		public float strokeOpacity => 0f;

		public float strokeWidth => 0f;

		public float miterLimit => 0f;

		public float[] dashArray => null;

		public float dashOffset => 0f;

		public SVGStrokeLineCapMethod strokeLineCap => default(SVGStrokeLineCapMethod);

		public SVGStrokeLineJoinMethod strokeLineJoin => default(SVGStrokeLineJoinMethod);

		public SVGFillRule fillRule => default(SVGFillRule);

		public Dictionary<string, Dictionary<string, string>> cssStyle => null;

		public List<List<Vector2>> clipPathList => null;

		public Dictionary<string, SVGLinearGradientElement> linearGradList => null;

		public Dictionary<string, SVGRadialGradientElement> radialGradList => null;

		public Dictionary<string, SVGConicalGradientElement> conicalGradList => null;

		public string gradientID => null;

		private void InitDefaults()
		{
		}

		public SVGPaintable()
		{
		}

		public SVGPaintable(Node node)
		{
		}

		public void AddCSS(string cssString)
		{
		}

		private List<List<Vector2>> CloneClipPathList(List<List<Vector2>> input)
		{
			return null;
		}

		public SVGPaintable(SVGPaintable inheritPaintable, Node node)
		{
		}

		private void Initialize(AttributeList attrList)
		{
		}

		public void ReadCSS(Node node)
		{
		}

		public void ReadCSSElement(Dictionary<string, string> element)
		{
		}

		public void SetViewport(Rect viewport)
		{
		}

		private void ReadStyle(string styleString)
		{
		}

		private void ReadClipPath(string clipPathValue)
		{
		}

		private List<List<Vector2>> GetClipPath(Node node, SVGMatrix svgMatrix)
		{
			return null;
		}

		private void ReadStyle(Dictionary<string, string> _dictionary)
		{
		}

		private void SetVisibility(string visibilityType)
		{
		}

		private void SetOverflow(string overflowType)
		{
		}

		private void SetClipRule(string clipRuleType)
		{
		}

		private void SetDisplay(string displayType)
		{
		}

		private void SetDashArray(string[] dashArrayType)
		{
		}

		private void SetFillRule(string fillRuleType)
		{
		}

		private void SetStrokeLineCap(string lineCapType)
		{
		}

		private void SetStrokeLineJoin(string lineCapType)
		{
		}

		public bool IsLinearGradiantFill()
		{
			return false;
		}

		public bool IsRadialGradiantFill()
		{
			return false;
		}

		public bool IsConicalGradiantFill()
		{
			return false;
		}

		public bool IsSolidFill()
		{
			return false;
		}

		public bool IsFill()
		{
			return false;
		}

		public bool IsFillX()
		{
			return false;
		}

		public bool IsStroke()
		{
			return false;
		}

		public SVGPaintMethod GetPaintType()
		{
			return default(SVGPaintMethod);
		}

		public void AppendLinearGradient(SVGLinearGradientElement linearGradElement)
		{
		}

		public void AppendRadialGradient(SVGRadialGradientElement radialGradElement)
		{
		}

		public void AppendConicalGradient(SVGConicalGradientElement conicalGradElement)
		{
		}

		public SVGLinearGradientBrush GetLinearGradientBrush(Rect bounds, SVGMatrix matrix, Rect viewport)
		{
			return null;
		}

		public SVGRadialGradientBrush GetRadialGradientBrush(Rect bounds, SVGMatrix matrix, Rect viewport)
		{
			return null;
		}

		public SVGConicalGradientBrush GetConicalGradientBrush(Rect bounds, SVGMatrix matrix, Rect viewport)
		{
			return null;
		}
	}
}
