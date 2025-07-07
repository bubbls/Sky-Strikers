using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.TempFeatures.Halloween
{
	public class BlackFog : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BlackFog _003C_003E4__this;

			private WaitForSeconds _003CpauseTime_003E5__2;

			private WaitForSeconds _003CplayInterval_003E5__3;

			private float _003CelapsedTime_003E5__4;

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
			public _003CAnimCoroutine_003Ed__10(int _003C_003E1__state)
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
		private float _playInterval;

		[SerializeField]
		private float _animDuration;

		[SerializeField]
		private float _animPauseDuration;

		[SerializeField]
		private MeshRenderer[] _meshRenderers;

		private bool _isAnimating;

		private float _elapsedTime;

		private Coroutine _animCoroutine;

		private static readonly int _mainAlpha;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CAnimCoroutine_003Ed__10))]
		private IEnumerator AnimCoroutine()
		{
			return null;
		}

		private void SetColor(float alpha)
		{
		}
	}
}
