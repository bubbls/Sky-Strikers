using System;
using SVGImporter;
using UnityEngine;

namespace DP.VectorGraphics
{
	[Serializable]
	public class SVGSettings
	{
		public SVGAssetFormat SVGFormat;

		public SVGUseGradients UseGradients;

		public bool Antialiasing;

		public float Scale;

		public Vector2 PivotPoint;

		public bool IgnoreSVGCanvas;
	}
}
