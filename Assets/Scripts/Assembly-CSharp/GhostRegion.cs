using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GhostRegion : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGenerateRandomPointAfterDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GhostRegion _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGenerateRandomPointAfterDelay_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private GhostController ghostController;

	private bool isRunning;

	private float time;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void Update()
	{
	}

	private void Chase()
	{
	}

	private void Hunt()
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateRandomPointAfterDelay_003Ed__8))]
	private IEnumerator GenerateRandomPointAfterDelay()
	{
		return null;
	}
}
