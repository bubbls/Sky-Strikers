using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Shop.Common
{
	public class VRPhysicsButtonInteraction : MonoBehaviour
	{
		[SerializeField]
		private LayerMask _handLayer;

		public event Action<bool> OnPlayerHandEnter
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
