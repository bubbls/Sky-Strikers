using System;
using DP.Takeaway.Runtime;
using SVGImporter;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class SVGVisual : KeyIndexedVisual
	{
		[Serializable]
		private class SVGAssetConfig
		{
			public SVGAsset asset;

			public Color Color;
		}

		[Serializable]
		private class Lookup : SerializableDictionary<string, SVGAssetConfig>
		{
		}

		[SerializeField]
		private Lookup _lookup;

		[SerializeField]
		private SVGImage _image;

		[SerializeField]
		private SVGRenderer _renderer;

		public override void SetVisual(string key)
		{
		}
	}
}
