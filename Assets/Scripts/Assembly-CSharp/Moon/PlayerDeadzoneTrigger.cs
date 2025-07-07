using System;
using System.Runtime.CompilerServices;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class PlayerDeadzoneTrigger : MonoBehaviour
	{
		public event Action<IDeadzoneInfo> OnTriggeredDeadZone
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
