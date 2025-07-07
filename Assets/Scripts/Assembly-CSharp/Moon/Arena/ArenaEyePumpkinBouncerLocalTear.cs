using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaEyePumpkinBouncerLocalTear : MonoBehaviour
	{
		public bool IsOnTheGroundLocally { get; private set; }

		public event Action OnTearHitGroundLocally
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

		public void ToggleIsOnTheGroundLocally(bool isOnTheGround)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
