using System;
using System.Collections.Generic;
using UnityEngine;

namespace SVGImporter
{
	[Serializable]
	public class LayerSelection
	{
		[SerializeField]
		[HideInInspector]
		protected List<int> _layers;

		protected HashSet<int> _cache;

		public List<int> layers => null;

		public HashSet<int> cache => null;

		public void Add(int index)
		{
		}

		public void Remove(int index)
		{
		}

		public bool Contains(int index)
		{
			return false;
		}

		public void UpdateCache()
		{
		}

		public void ClearCache()
		{
		}

		public void Clear()
		{
		}
	}
}
