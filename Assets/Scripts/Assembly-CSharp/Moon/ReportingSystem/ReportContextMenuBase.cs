using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public abstract class ReportContextMenuBase : MonoBehaviour
	{
		public abstract bool IsShowing { get; }

		public event Action<BadBehaviour> RequestReport
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

		protected void SendRequestReport(BadBehaviour badBehaviour)
		{
		}

		public abstract void ResetToInitialStatus();

		public abstract void Toggle(bool show, Action callback = null);
	}
}
