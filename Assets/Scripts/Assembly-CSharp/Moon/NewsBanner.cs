using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using JetBrains.Annotations;
using Moon.Bootstrap;
using Moon.Framework.Base;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class NewsBanner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public TaskCompletionSource<Sprite> tcs;

			public NewsBanner _003C_003E4__this;

			public string url;

			public float scale;

			internal void _003CDownloadSpriteFromUrl_003Eb__0()
			{
			}

			internal void _003CDownloadSpriteFromUrl_003Eb__1(WebRequestResponseData responseData)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateSpriteFromObjectAsync_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public string imageObjectName;

			public NewsBanner _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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
		private struct _003CDownloadSpriteFromUrl_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public NewsBanner _003C_003E4__this;

			public string url;

			public float scale;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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
		private struct _003CUpdateContentsAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NewsBanner _003C_003E4__this;

			private TaskAwaiter<TitleNewsItem> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CUpdateSpriteAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public IDictionary<string, object> itemContent;

			public string imageNameKey;

			public NewsBanner _003C_003E4__this;

			public CancellationToken cancellationToken;

			public SpriteRenderer sprRenderer;

			private bool _003Cdone_003E5__2;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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

		private const string NewsKey = "--news--";

		private const string ContentKey = "content";

		private const string ImageLeftKey = "image_left";

		private const string ImageRightKey = "image_right";

		private const string LastSeenNewsVersionKey = "LastSeenNewsVersion";

		private static readonly Regex _imageRegex;

		[SerializeField]
		private TMP_Text _textContent;

		[SerializeField]
		private SpriteRenderer _sprLeft;

		[SerializeField]
		private SpriteRenderer _sprRight;

		[SerializeField]
		private LocalPlayerCheckVolume _localPlayerCheck;

		[SerializeField]
		private GameObject _notificationObj;

		[SerializeField]
		private float _readTime;

		private CancellationTokenSource _cts;

		private IMessageSubscriber _subscriber;

		private bool _updating;

		[CanBeNull]
		private string _currentNewsVersion;

		private int _readTimerId;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LocalPlayerCheckVolume_OnChanged(bool hasPlayer)
		{
		}

		private void MarkNewsAsRead()
		{
		}

		private void CancelReadTimer()
		{
		}

		private int HandleConnChanged(IMessage<ConnChangedMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CUpdateContentsAsync_003Ed__25))]
		private void UpdateContentsAsync()
		{
		}

		private static string UnescapeString(string escapedString)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateSpriteAsync_003Ed__27))]
		private Task UpdateSpriteAsync(IDictionary<string, object> itemContent, string imageNameKey, SpriteRenderer sprRenderer, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateSpriteFromObjectAsync_003Ed__28))]
		private Task<Sprite> CreateSpriteFromObjectAsync(string imageObjectName, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDownloadSpriteFromUrl_003Ed__29))]
		private Task<Sprite> DownloadSpriteFromUrl(string url, float scale, CancellationToken cancellationToken)
		{
			return null;
		}

		private void HandleImageDownloaded(string url, float scale, WebRequestResponseData responseData, TaskCompletionSource<Sprite> tcs)
		{
		}

		private Sprite CreateSpriteFromBytes(byte[] data, float scale)
		{
			return null;
		}

		private static string GetServerMaintenanceString()
		{
			return null;
		}

		private void ToggleReadTracking(bool toggleOn)
		{
		}

		[ContextMenu("Delete Last Seen News Version")]
		private void DeleteLastSeenNewsVersion()
		{
		}
	}
}
