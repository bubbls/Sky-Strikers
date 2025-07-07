using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace Chamber8.Framework.Common.Http
{
	public class Chamber8Http : SingleMonoBehaviour<Chamber8Http, DefaultSingleMonoBehaviourSettings<Chamber8Http>>
	{
		[CompilerGenerated]
		private sealed class _003CDoGet_003Ed__2<TData> : IEnumerator<object>, IEnumerator, IDisposable where TData : class
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GetRequest request;

			public Chamber8Http _003C_003E4__this;

			public Action<TData> onSuccess;

			public Action<Error> onError;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CDoGet_003Ed__2(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPost_003Ed__3<TData> : IEnumerator<object>, IEnumerator, IDisposable where TData : class
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MultipartFormRequest request;

			public Chamber8Http _003C_003E4__this;

			public Action<TData> onSuccess;

			public Action<Error> onError;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CPost_003Ed__3(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPost_003Ed__4<TData> : IEnumerator<object>, IEnumerator, IDisposable where TData : class
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WWWFormRequest formRequest;

			public Chamber8Http _003C_003E4__this;

			public Action<TData> onSuccess;

			public Action<Error> onError;

			private UnityWebRequest _003Creq_003E5__2;

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
			public _003CPost_003Ed__4(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPost_003Ed__5<TData> : IEnumerator<object>, IEnumerator, IDisposable where TData : class
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RawHttpRequest reqContainer;

			public Chamber8Http _003C_003E4__this;

			public Action<TData> onSuccess;

			public Action<Error> onError;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CPost_003Ed__5(int _003C_003E1__state)
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

		public void Post<TData>(IHttpRequest httpRequest, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
		}

		public void Get<TData>(GetRequest request, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
		}

		[IteratorStateMachine(typeof(_003CDoGet_003Ed__2<>))]
		private IEnumerator DoGet<TData>(GetRequest request, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPost_003Ed__3<>))]
		private IEnumerator Post<TData>(MultipartFormRequest request, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPost_003Ed__4<>))]
		private IEnumerator Post<TData>(WWWFormRequest formRequest, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPost_003Ed__5<>))]
		private IEnumerator Post<TData>(RawHttpRequest reqContainer, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
			return null;
		}

		private void HandleResp<TData>(UnityWebRequest www, AbstractHttpRequest reqContainer, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
		}

		private static void AddHeaders(AbstractHttpRequest request, UnityWebRequest www)
		{
		}

		private static void OnResponse<TData>(long code, string response, AbstractHttpRequest reqContainer, Action<TData> onSuccess, Action<Error> onError) where TData : class
		{
		}

		private static byte[] Serialize(object payload)
		{
			return null;
		}
	}
}
