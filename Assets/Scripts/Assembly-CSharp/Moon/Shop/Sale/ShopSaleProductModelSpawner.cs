using System;
using System.Collections.Generic;
using UnityEngine;

namespace Moon.Shop.Sale
{
	[Obsolete]
	public class ShopSaleProductModelSpawner : MonoBehaviour
	{
		[SerializeField]
		private List<Transform> _spawnModelPoints;

		private readonly List<GameObject> _spawnedModels;

		private bool _isInitialized;

		public void Unload()
		{
		}

		public GameObject? GetSpawnedModel(int p0)
		{
			return null;
		}
	}
}
