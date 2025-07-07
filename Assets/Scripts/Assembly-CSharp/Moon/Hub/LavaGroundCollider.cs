using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Hub
{
	public class LavaGroundCollider : MonoBehaviour
	{
		public event Action<MBall, Collision> OnBallCollided
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

		private void OnCollisionEnter(Collision other)
		{
		}
	}
}
