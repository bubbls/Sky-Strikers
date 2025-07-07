using System;
using System.Collections.Generic;
using UnityEngine;

namespace SVGImporter.Rendering
{
	[Serializable]
	public class CCGradient
	{
		public const string DEFAULT_GRADIENT_HASH = "GC999FFFFFFC000FFFFFFA999999A000999";

		public CCGradientColorKey[] colorKeys;

		public CCGradientAlphaKey[] alphaKeys;

		public int index;

		[NonSerialized]
		[HideInInspector]
		public int atlasIndex;

		[NonSerialized]
		[HideInInspector]
		protected List<ISVGReference> _references;

		[NonSerialized]
		public Action<ISVGReference> onReferenceAdded;

		[NonSerialized]
		public Action<ISVGReference> onReferenceRemoved;

		public string hash => null;

		public List<ISVGReference> references => null;

		public int referenceCount => 0;

		public bool initialised => false;

		public bool AddReference(ISVGReference reference)
		{
			return false;
		}

		public bool RemoveReference(ISVGReference reference)
		{
			return false;
		}

		public int CountReferences(ISVGReference reference)
		{
			return 0;
		}

		public CCGradient(CCGradientColorKey[] colorKeys, CCGradientAlphaKey[] alphaKeys, bool sort = true)
		{
		}

		public void SetKeys(CCGradientColorKey[] colorKeys, CCGradientAlphaKey[] alphaKeys, bool sort = true)
		{
		}

		public Color32 Evaluate(float time)
		{
			return default(Color32);
		}

		public Color32 ApproximateColor(int samples)
		{
			return default(Color32);
		}

		public CCGradient Clone()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static string ColorToHex(Color32 color)
		{
			return null;
		}

		public static Color HexToColor(string hex)
		{
			return default(Color);
		}
	}
}
