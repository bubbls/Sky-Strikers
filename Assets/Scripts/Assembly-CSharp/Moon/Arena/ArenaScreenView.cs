using System;
using UnityEngine;

namespace Moon.Arena
{
	public abstract class ArenaScreenView : MonoBehaviour, IDisposable
	{
		public abstract void Initialize();

		public abstract void Dispose();

		public void EnterView(object viewData = null)
		{
		}

		protected abstract void EnterViewInternal(object viewData = null);

		public void ExitView()
		{
		}

		protected abstract void ExitViewInternal();
	}
}
