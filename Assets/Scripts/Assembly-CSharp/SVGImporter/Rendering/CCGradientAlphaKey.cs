using System;

namespace SVGImporter.Rendering
{
	[Serializable]
	public struct CCGradientAlphaKey
	{
		public float time;

		public float alpha;

		public CCGradientAlphaKey(float alpha, float time)
		{
			this.time = 0f;
			this.alpha = 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
