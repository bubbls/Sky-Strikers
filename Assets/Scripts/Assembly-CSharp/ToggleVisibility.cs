using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CToggleObjectVisibility_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject obj;

		public float interval;

		public float duration;

		private float _003CstartTime_003E5__2;

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
		public _003CToggleObjectVisibility_003Ed__4(int _003C_003E1__state)
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

	public GameObject targetObject;

	public float toggleInterval;

	public float totalDuration;

	public void ShowAlert()
	{
	}

	[IteratorStateMachine(typeof(_003CToggleObjectVisibility_003Ed__4))]
	private IEnumerator ToggleObjectVisibility(GameObject obj, float interval, float duration)
	{
		return null;
	}
}
