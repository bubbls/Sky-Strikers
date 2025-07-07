using System;
using UnityEngine;

namespace SVGImporter.Rendering
{
	[Serializable]
	public class SVGFill
	{
		public FILL_TYPE fillType;

		public FILL_BLEND blend;

		public GRADIENT_TYPE gradientType;

		public Color32 color;

		public float opacity;

		public Rect viewport;

		public SVGMatrix transform;

		public string gradientId;

		public CCGradient gradientColors;

		public string gradientHash => null;

		public Color32 finalColor => default(Color32);

		public SVGFill()
		{
		}

		public SVGFill(Color32 color)
		{
		}

		public SVGFill(Color32 color, FILL_BLEND blend)
		{
		}

		public SVGFill(Color32 color, FILL_BLEND blend, FILL_TYPE fillType)
		{
		}

		public SVGFill(Color32 color, FILL_BLEND blend, FILL_TYPE fillType, GRADIENT_TYPE gradientType)
		{
		}

		public SVGFill Clone()
		{
			return null;
		}
	}
}
