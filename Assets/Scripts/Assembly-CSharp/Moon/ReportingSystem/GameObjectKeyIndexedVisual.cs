using System;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class GameObjectKeyIndexedVisual : KeyIndexedVisual
	{
		[Serializable]
		private class Lookup : SerializableDictionary<string, GameObject>
		{
		}

		[SerializeField]
		private Lookup _lookup;

		public override void SetVisual(string key)
		{
		}
	}
}
