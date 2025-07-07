using System.Collections.Generic;
using SVGImporter.Rendering;

namespace SVGImporter
{
	public class SVGAtlasData
	{
		public CCGradient[] gradients;

		public Dictionary<string, CCGradient> gradientCache;

		public void Init(int length)
		{
		}

		public void ClearGradientCache()
		{
		}

		public void InitGradientCache()
		{
		}

		public void RebuildGradientCache()
		{
		}

		public static CCGradient GetDefaultGradient()
		{
			return null;
		}

		public CCGradient AddGradient(CCGradient gradient)
		{
			return null;
		}

		public CCGradient AddGradient(CCGradient gradient, out bool gradientExist)
		{
			gradientExist = default(bool);
			return null;
		}

		public bool RemoveGradient(CCGradient gradient)
		{
			return false;
		}

		public CCGradient GetGradient(int index)
		{
			return null;
		}

		public SVGFill GetGradient(SVGFill gradient)
		{
			return null;
		}

		public CCGradient GetGradient(CCGradient gradient)
		{
			return null;
		}

		public bool HasGradient(CCGradient gradient)
		{
			return false;
		}

		public void Clear()
		{
		}
	}
}
