using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Moon.Portal
{
	public class RenderPortals : MonoBehaviour
	{
		private class PortalRenderInfo
		{
			public Camera PortalCamera;

			public RenderTexture TexLeftEye;

			public RenderTexture TexRightEye;
		}

		[SerializeField]
		private float _screenFactor;

		private readonly Dictionary<RenderedPortal, PortalRenderInfo> _renderInfos;

		public static event Action<Camera> OnBeforeRenderPortalCamera
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RenderPortal(ScriptableRenderContext context, Camera renderingCamera)
		{
		}

		private void RenderPortalCamera(RenderedPortal portal, Camera renderingCamera, ScriptableRenderContext context)
		{
		}

		private static void RenderOneEye(RenderedPortal portal, Camera renderingCamera, ScriptableRenderContext context, PortalRenderInfo renderInfo, Camera.MonoOrStereoscopicEye eye)
		{
		}

		private static void UpdatePortalCamera(Camera.MonoOrStereoscopicEye eye, PortalRenderInfo renderInfo, RenderedPortal portal, Camera renderingCamera)
		{
		}

		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projectionMatrix, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		private PortalRenderInfo InitializePortalRenderInfo(RenderedPortal portal, Camera renderingCamera)
		{
			return null;
		}

		private void InitializeTextures(PortalRenderInfo renderInfo)
		{
		}

		private void CreateTextureIfNeeded(ref RenderTexture texture, int desiredWidth, int desiredHeight)
		{
		}

		private RenderTextureDescriptor GetTextureDescriptor()
		{
			return default(RenderTextureDescriptor);
		}

		private void CollectPortalResources(RenderedPortal portal)
		{
		}

		private void CollectPortalResources(PortalRenderInfo renderInfo)
		{
		}
	}
}
