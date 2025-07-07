using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using moveen.descs;

namespace moveen.utils
{
	public abstract class OrderedMonoBehaviour : MonoBehaviour, IOrderableTick
	{
		[CompilerGenerated]
		private sealed class _003CstartAfterPhysics_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OrderedMonoBehaviour _003C_003E4__this;

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
			public _003CstartAfterPhysics_003Ed__17(int _003C_003E1__state)
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

		[Tooltip("Execution order in OrderedTick system")]
		public int executionOrder;

		[NonSerialized]
		private bool exceptionsInTick;

		[NonSerialized]
		public bool participateInTick;

		[NonSerialized]
		public bool participateInFixedTick;

		private bool fixedUpdateOnce;

		private static bool coroutineStarted;

		[NonSerialized]
		private bool coroutineOwner;

		[NonSerialized]
		private float lastExecutionOrder;

		public int getOrder()
		{
			return 0;
		}

		public abstract void tick(float dt);

		public virtual void fixedTick(float dt)
		{
		}

		public bool getParticipateInTick()
		{
			return false;
		}

		public bool getParticipateInFixedTick()
		{
			return false;
		}

		public void setExceptionsInTick(bool value)
		{
		}

		public bool getIsExceptionsInTick()
		{
			return false;
		}

		public virtual void Update()
		{
		}

		public void LateUpdate()
		{
		}

		public void FixedUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CstartAfterPhysics_003Ed__17))]
		private IEnumerator startAfterPhysics()
		{
			return null;
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		private void removeFromOrderedTick()
		{
		}

		public virtual void OnValidate()
		{
		}
	}
}
