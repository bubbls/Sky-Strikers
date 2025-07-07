using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PropCollect : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveBox_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PropCollect _003C_003E4__this;

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
		public _003CMoveBox_003Ed__22(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRotateBox_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PropCollect _003C_003E4__this;

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
		public _003CRotateBox_003Ed__23(int _003C_003E1__state)
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

	public GameObject prop;

	public GameObject rewardBox;

	public GameObject lotteryButton;

	public GameObject BoxButton;

	public Transform Console;

	public Transform objectA;

	public Transform objectB;

	public Transform objectC;

	public Transform objectD;

	public Transform objectE;

	public Transform ButtonBase;

	public Transform ButtonSphere;

	private bool isTriggered;

	private bool isExecutable;

	private bool isDoorClosed;

	public Material targetMaterial;

	private Material originalMaterial;

	private Renderer propRenderer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void CloseDoor()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveBox_003Ed__22))]
	private IEnumerator MoveBox()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRotateBox_003Ed__23))]
	private IEnumerator RotateBox()
	{
		return null;
	}
}
