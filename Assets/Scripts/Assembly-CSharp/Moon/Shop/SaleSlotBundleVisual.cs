using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Moon.Shop
{
	public class SaleSlotBundleVisual : SaleSlotVisual
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateBackgroundImageAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(string? Url, Texture? Texture)> _003C_003Et__builder;

			public string tag;

			public MeshRenderer meshRenderer;

			public string cachedImageUrl;

			public Texture cachedTexture;

			public List<Image> images;

			private string _003CimageUrl_003E5__2;

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

		private const string WallTag = "SaleSlot_Wall";

		private const string FloorTag = "SaleSlot_Floor";

		private static readonly int _mirrorTexture;

		[SerializeField]
		private MeshRenderer? _bgMeshRenderer;

		[SerializeField]
		private MeshRenderer? _groundMeshRenderer;

		private string? _curBgImageUrl;

		private Texture? _curBgMeshTexture;

		private string? _curGroundImageUrl;

		private Texture? _curGroundMeshTexture;

		private void OnDestroy()
		{
		}

		protected override void HandleSlotUpdated()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateBackgroundImageAsync_003Ed__11))]
		private static Task<(string?, Texture?)>? UpdateBackgroundImageAsync(List<Image> images, string tag, MeshRenderer? meshRenderer, string? cachedImageUrl, Texture? cachedTexture)
		{
			return null;
		}

		private void TryUnloadTextures()
		{
		}
	}
}
