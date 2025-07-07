using System;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class MeshRendererVisual : KeyIndexedVisual
	{
		[Serializable]
		private class Lookup : SerializableDictionary<string, Material>
		{
		}

		[SerializeField]
		private MeshRenderer _renderer;

		[SerializeField]
		private Lookup _lookup;

		public override void SetVisual(string key)
		{
		}
	}
}
