using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerVisualsPresetLoader : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadBulwarpVisuals_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerVisualsPresetPoints points;

			public PlayerVisualsConfig config;

			public PlayerVisualsPresetLoader _003C_003E4__this;

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
			public _003CLoadBulwarpVisuals_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003CLoadSuitWeaponVisuals_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerVisualsPresetPoints points;

			public PlayerVisualsConfig config;

			public PlayerVisualsPresetLoader _003C_003E4__this;

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
			public _003CLoadSuitWeaponVisuals_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003CLoadVisualsRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerVisualsPresetLoader _003C_003E4__this;

			public PlayerVisualsPresetPoints points;

			public PlayerVisualsConfig visualsConfig;

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
			public _003CLoadVisualsRoutine_003Ed__5(int _003C_003E1__state)
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

		private PlayerVisualsPresetPoints _points;

		private readonly WaitForEndOfFrame _waitForEndOfFrame;

		public List<VisualBase> LoadedVisuals { get; }

		[IteratorStateMachine(typeof(_003CLoadVisualsRoutine_003Ed__5))]
		public IEnumerator LoadVisualsRoutine(PlayerVisualsConfig visualsConfig, PlayerVisualsPresetPoints points)
		{
			return null;
		}

		private IEnumerator GetSuitClassEnumerator(PlayerVisualsConfig config, PlayerVisualsPresetPoints points)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadSuitWeaponVisuals_003Ed__7))]
		private IEnumerator LoadSuitWeaponVisuals(PlayerVisualsConfig config, PlayerVisualsPresetPoints points)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadBulwarpVisuals_003Ed__8))]
		private IEnumerator LoadBulwarpVisuals(PlayerVisualsConfig config, PlayerVisualsPresetPoints points)
		{
			return null;
		}
	}
}
