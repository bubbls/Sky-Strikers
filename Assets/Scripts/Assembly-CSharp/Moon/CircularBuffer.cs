using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Moon
{
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__26 : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public CircularBuffer<T> _003C_003E4__this;

			private IEnumerator<ArraySegment<T>> _003C_003E7__wrap1;

			private ArraySegment<T> _003Csegment_003E5__3;

			private int _003Ci_003E5__4;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CGetEnumerator_003Ed__26(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private readonly T[] _buffer;

		private int _start;

		private int _end;

		private int _size;

		public int Capacity => 0;

		public bool IsFull => false;

		public bool IsEmpty => false;

		public int Size => 0;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public CircularBuffer(int capacity)
		{
		}

		public CircularBuffer(int capacity, T[] items)
		{
		}

		public T Front()
		{
			return default(T);
		}

		public T Back()
		{
			return default(T);
		}

		public void PushBack(T item)
		{
		}

		public void PushFront(T item)
		{
		}

		public void PopBack()
		{
		}

		public void PopFront()
		{
		}

		public void Clear()
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public IList<ArraySegment<T>> ToArraySegments()
		{
			return null;
		}

		[IteratorStateMachine(typeof(CircularBuffer<>._003CGetEnumerator_003Ed__26))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
		{
		}

		private void Increment(ref int index)
		{
		}

		private void Decrement(ref int index)
		{
		}

		private int InternalIndex(int index)
		{
			return 0;
		}

		private ArraySegment<T> ArrayOne()
		{
			return default(ArraySegment<T>);
		}

		private ArraySegment<T> ArrayTwo()
		{
			return default(ArraySegment<T>);
		}
	}
}
