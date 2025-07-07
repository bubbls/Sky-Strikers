using System;
using System.Runtime.CompilerServices;
using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class MBulwarpBallAreaDespawnableHitbox : MonoBehaviour, IBallAreaDespawnable
	{
		public event Action OnDespawnInBallAreaRequested
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

		void IBallAreaDespawnable.DespawnInBallArea()
		{
		}
	}
}
