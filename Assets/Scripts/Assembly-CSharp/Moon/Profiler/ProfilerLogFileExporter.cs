using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using UnityEngine.Scripting;

namespace Moon.Profiler
{
	[Preserve]
	public class ProfilerLogFileExporter : IInitializer
	{
		[CompilerGenerated]
		private sealed class _003CExportProfile_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProfilerLogFileExporter _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CExportProfile_003Ed__11(int _003C_003E1__state)
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

		private const string ExportPath = "profilerlog";

		private const int FrameCount = 300;

		private int _count;

		private bool _started;

		private string _currentFolder;

		public void Initialize()
		{
		}

		public bool IsStarted()
		{
			return false;
		}

		public void OnToggleChanged(bool isOn)
		{
		}

		private void Start()
		{
		}

		private void Stop()
		{
		}

		private void CreateFolder()
		{
		}

		[IteratorStateMachine(typeof(_003CExportProfile_003Ed__11))]
		private IEnumerator ExportProfile()
		{
			return null;
		}
	}
}
