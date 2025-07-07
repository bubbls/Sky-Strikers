using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Arena
{
	public abstract class CrowdResponseChecker : MonoBehaviour
	{
		public event Action<byte> OnResponseTriggered
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

		public abstract void Initialize();

		public abstract void Dispose();

		protected void NotifyResponseTriggered(byte response, bool broadcastMessage)
		{
		}
	}
}
