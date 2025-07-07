using System;
using System.Runtime.CompilerServices;
using Moon.Arena;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Shop.TryOn
{
	[Obsolete]
	public class ShopTryOnArea : MonoBehaviour
	{
		[SerializeField]
		private SphereCollider _sphereCollider;

		[SerializeField]
		private Transform _spawnModelPoint;

		private GameObject _modelGameObject;

		private PlayerVisualBase _modelPlayerVisual;

		public event Action<bool, ShopTryOnArea> OnToggleTryOnProduct
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void ToggleTryOnArea(bool enable)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void SetTeamColor(TeamNo teamNo)
		{
		}
	}
}
