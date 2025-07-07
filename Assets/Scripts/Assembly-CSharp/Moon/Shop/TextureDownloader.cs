using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Moon.Framework.Base;
using UnityEngine;

namespace Moon.Shop
{
	public class TextureDownloader
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public TaskCompletionSource<Texture?> tcs;

			public string url;

			internal void _003CDownloadTextureFromUrlAsync_003Eb__0()
			{
			}

			internal void _003CDownloadTextureFromUrlAsync_003Eb__1(WebRequestResponseData responseData)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownloadAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Texture> _003C_003Et__builder;

			public TextureDownloader _003C_003E4__this;

			public string imageUrl;

			private TaskAwaiter<Texture?> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownloadTextureFromUrlAsync_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Texture> _003C_003Et__builder;

			public string url;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			private TaskAwaiter<Texture?> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private string? _downloadingImageUrl;

		private CancellationTokenSource? _downloadingCts;

		[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__2))]
		public Task<Texture> DownloadAsync(string imageUrl)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDownloadTextureFromUrlAsync_003Ed__3))]
		private static Task<Texture> DownloadTextureFromUrlAsync(string url, CancellationToken cancellationToken)
		{
			return null;
		}

		private static Texture CreateTextureFromBytes(byte[] data)
		{
			return null;
		}

		private static void HandleImageDownloaded(string url, WebRequestResponseData responseData, TaskCompletionSource<Texture?> tcs)
		{
		}
	}
}
