using UnityEngine;

namespace Moon.Portal
{
	public class RenderedPortal : TravellerPortal
	{
		private static readonly int TexLeftEye;

		private static readonly int TexRightEye;

		[SerializeField]
		private MeshRenderer _portalRenderer;

		[SerializeField]
		private Transform _clipPlane;

		[SerializeField]
		private bool _useCullingMask;

		[SerializeField]
		private LayerMask _cullingMask;

		private RenderedPortal _linkedRenderedPortal;

		public Transform ClipPlane => null;

		public bool UseCullingMask => false;

		public LayerMask CullingMask => default(LayerMask);

		private void Start()
		{
		}

		public void BeginRenderPortal()
		{
		}

		public void EndRenderPortal(Texture leftEye, Texture rightEye)
		{
		}

		public bool IsVisibleInCamera(Camera renderingCamera)
		{
			return false;
		}
	}
}
