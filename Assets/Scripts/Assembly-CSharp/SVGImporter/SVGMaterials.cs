using System;
using UnityEngine;

namespace SVGImporter
{
	[Serializable]
	public struct SVGMaterials
	{
		public Material GradientColorAlphaBlended;

		public Material GradientColorAlphaBlendedAntiAliased;

		public Material GradientColorOpaque;

		public Material SolidColorAlphaBlended;

		public Material SolidColorAlphaBlendedAntiAliased;

		public Material SolidColorOpaque;

		public Material UI;

		public Material UIAntiAliased;
	}
}
