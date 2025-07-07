using System;
using DP.Takeaway.Runtime;
using SVGImporter;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class SVGVisualColor : KeyIndexedVisual
	{
		[Serializable]
		private class Lookup : SerializableDictionary<string, Color>
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
