using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.SNS
{
	public class EnableBehaviour : MonoBehaviour
	{
		[SerializeField]
		private Behaviour _behaviour;

		public bool Enabled => false;

		public event Action? OnEnableChanges
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

		public void SetEnable(bool enable)
		{
		}
	}
}
