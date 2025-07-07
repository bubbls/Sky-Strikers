using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Profiler
{
	public static class DebugPanelCenter
	{
		private class PanelWrapper : IDebugPanelInterface
		{
			public TextGetter name;

			public BoolGetter enable;

			public TextGetter title;

			public PanelInitProc init;

			public PanelReleaseProc release;

			public string DebugPanelName => null;

			public bool DebugPanelEnable => false;

			public string DebugPanelTitle => null;

			public void OnDebugPanelInitialize(IDebugPanelDrawContext ctx)
			{
			}

			public void OnDebugPanelRelease()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAsyncLoad_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private ResourceRequest _003Crr_003E5__2;

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
			public _003CAsyncLoad_003Ed__11(int _003C_003E1__state)
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

		private static readonly string prefabPath;

		private static DebugPanelUI ui;

		private static bool loading;

		private static List<IDebugPanelInterface> dps;

		private static IDebugPanelInterface actived;

		public static DebugPanelUI GetUi()
		{
			return null;
		}

		public static IDebugPanelInterface RegisterPanelWrapper(TextGetter name, BoolGetter enable, TextGetter title, PanelInitProc init, PanelReleaseProc release, bool active = false)
		{
			return null;
		}

		public static void RegisterPanel(IDebugPanelInterface dp, bool active = false)
		{
		}

		public static void UnregisterPanel(IDebugPanelInterface dp)
		{
		}

		public static void Enable(MonoBehaviour loader = null)
		{
		}

		[IteratorStateMachine(typeof(_003CAsyncLoad_003Ed__11))]
		private static IEnumerator AsyncLoad()
		{
			return null;
		}

		private static void LoadFinish(GameObject prefab)
		{
		}

		private static void AfterInit()
		{
		}

		public static void StartCoroutine(IEnumerator coroutine)
		{
		}

		public static void StopCoroutine(IEnumerator coroutine)
		{
		}
	}
}
