using System;
using DP.Takeaway.Runtime;
using TMPro;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class TextVisual : KeyIndexedVisual
	{
		[Serializable]
		private class Lookup : SerializableDictionary<string, string>
		{
		}

		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private Lookup _lookup;

		public override void SetVisual(string key)
		{
		}
	}
}
