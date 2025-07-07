using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace VRKeys
{
	public class Key : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoActivateFor_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Key _003C_003E4__this;

			public float seconds;

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
			public _003CDoActivateFor_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CPress_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Key _003C_003E4__this;

			public Mallet mallet;

			public Collider other;

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
			public _003CPress_003Ed__20(int _003C_003E1__state)
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

		public Keyboard keyboard;

		public TextMeshPro label;

		public Material inactiveMat;

		public Material activeMat;

		public Material disabledMat;

		public Vector3 defaultPosition;

		public Vector3 pressedPosition;

		public Vector3 pressDirection;

		public float pressMagnitude;

		public bool autoInit;

		private bool isPressing;

		private bool disabled;

		protected MeshRenderer meshRenderer;

		private IEnumerator _ActivateFor;

		private IEnumerator _Press;

		private void Awake()
		{
		}

		public void Init(Vector3 defaultPos)
		{
		}

		private void OnEnable()
		{
		}

		protected virtual void OnEnableExtras()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		[IteratorStateMachine(typeof(_003CPress_003Ed__20))]
		private IEnumerator Press(Collider other, Mallet mallet)
		{
			return null;
		}

		public virtual void HandleTriggerEnter(Collider other)
		{
		}

		public void ActivateFor(float seconds)
		{
		}

		[IteratorStateMachine(typeof(_003CDoActivateFor_003Ed__23))]
		private IEnumerator DoActivateFor(float seconds)
		{
			return null;
		}

		public virtual void Disable()
		{
		}

		public virtual void Enable()
		{
		}

		public virtual void UpdateLayout(Layout translation)
		{
		}
	}
}
