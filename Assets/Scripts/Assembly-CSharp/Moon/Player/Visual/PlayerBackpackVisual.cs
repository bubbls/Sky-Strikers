using DG.Tweening;
using Moon.Arena;
using Moon.Backpack;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerBackpackVisual : PlayerVisualBase
	{
		[SerializeField]
		[Header("Slots")]
		private BackpackItemSlotsVisualController _slotsVisualController;

		[Header("Visual Config")]
		[SerializeField]
		private Transform _backpackVisualTransform;

		[Header("Waist")]
		[SerializeField]
		private GameObject _waistGrabObj;

		[SerializeField]
		private MeshRenderer _waistGrabObjMeshRender;

		[SerializeField]
		private Material _activeMaterial;

		[SerializeField]
		private Material _diactiveMaterial;

		[Header("Hood")]
		[SerializeField]
		private GameObject _backpackHood;

		[SerializeField]
		private Renderer _backpackHoodMeshRender;

		[SerializeField]
		private float _startValue;

		[SerializeField]
		private float _endValue;

		[SerializeField]
		private float _fadeDuration;

		private Vector3 _originalGrabPointLocalPosition;

		private Tween _backpackFadeTween;

		private static readonly int _dissolveOffset;

		private MGrabbableBackpack.BackpackState _oldState;

		private bool _firstRenderingFrame;

		private Vector3 _lastRenderingPosition;

		private Vector3 _scaleOnBack;

		private bool _hasHoodVisuals;

		public BackpackVisualTheme BackpackVisualTheme { get; private set; }

		public override int ThemeInt => 0;

		protected override void SetTheme(int theme)
		{
		}

		protected override void InitializeInternal()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetScaleOnBackpack(Vector3 scale)
		{
		}

		protected override void HandleOnPlayerSkeletonChanged(PlayerSkeleton playerSkeleton)
		{
		}

		public override void SetVisibleInMainCamera(bool visible)
		{
		}

		private void ShowHandleOnWaist(bool show)
		{
		}

		protected override PlayerMaterial GetPlayerMaterial(TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		private void Open(bool open, bool immediate = false)
		{
		}

		private void SetWaistMaterial(Material material)
		{
		}

		private void RenderPoseOnPlayerBack()
		{
		}

		private void RenderPose(Vector3 position, Quaternion rotation)
		{
		}

		private void RenderGrabbingSlot(BackpackItemSlot grabbingSlot, Vector3 position, Quaternion rotation, bool isLeft)
		{
		}

		public void Render(MGrabbableBackpack backpack)
		{
		}

		private void RenderInternal(MGrabbableBackpack backpack, MGrabbableBackpack.BackpackState oldState, MGrabbableBackpack.BackpackState state)
		{
		}
	}
}
