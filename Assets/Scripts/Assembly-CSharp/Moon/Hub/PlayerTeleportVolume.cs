using System;
using System.Runtime.CompilerServices;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Hub
{
	[RequireComponent(typeof(Collider))]
	public class PlayerTeleportVolume : MonoBehaviour
	{
		[SerializeField]
		private PlayerTeleportVolume[] _otherVolumes;

		[SerializeField]
		private bool _crossFromBehind;

		private bool _disable;

		[SerializeField]
		private bool _drawGizmos;

		[Range(0f, 360f)]
		[SerializeField]
		private float _checkXRot;

		[Range(0f, 360f)]
		[SerializeField]
		private float _checkYRot;

		public event Action BeforeTeleportAway
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

		public event Action BeforeTeleportHere
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

		public event Action OnTeleportedAway
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

		public event Action OnTeleportedHere
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

		[Button(null, EButtonEnableMode.Always)]
		private void Teleport()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void TeleportAndStop()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private PlayerTeleportVolume GetOtherPlace()
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
