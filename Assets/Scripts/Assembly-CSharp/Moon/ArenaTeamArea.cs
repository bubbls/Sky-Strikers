using System;
using System.Runtime.CompilerServices;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class ArenaTeamArea : MonoBehaviour
	{
		[SerializeField]
		private TeamNo _teamNo;

		public event Action<TeamNo, MBall> OnBallEnter
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
	}
}
