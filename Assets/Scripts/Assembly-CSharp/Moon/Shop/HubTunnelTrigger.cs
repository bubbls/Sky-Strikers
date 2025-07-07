using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Shop
{
	public class HubTunnelTrigger : MonoBehaviour
	{
		public event Action<bool> OnPlayerInside
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

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
