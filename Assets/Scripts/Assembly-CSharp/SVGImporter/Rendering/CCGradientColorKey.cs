using System;
using UnityEngine;

namespace SVGImporter.Rendering
{
	[Serializable]
	public struct CCGradientColorKey
	{
		public float time;

		public Color32 color;

		public CCGradientColorKey(Color32 color, float time)
		{
			this.time = 0f;
			this.color = default(Color32);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
