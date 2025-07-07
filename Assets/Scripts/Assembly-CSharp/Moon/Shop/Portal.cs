using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Shop
{
	public class Portal : MonoBehaviour
	{
		[SerializeField]
		private Portal _targetTeleportPoint;

		[SerializeField]
		private bool _teleportExitBehind;

		[SerializeField]
		private bool _teleportExitFront;

		private bool _isEnabled;

		public event Action OnPlayerEnterTeleportArea
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

		public event Action OnPlayerExitTeleportArea
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

		private void EnablePortal(bool enable)
		{
		}

		private void Teleport(Transform head)
		{
		}

		private bool IsSameDirection(Transform head, Transform targetTransform)
		{
			return false;
		}
	}
}
