using UnityEngine;
using UnityEngine.EventSystems;

namespace Moon
{
	[RequireComponent(typeof(LineRenderer))]
	public class CanvasPointerLine : MonoBehaviour
	{
		private enum VisibilityMode
		{
			OnlyOnCanvas = 0,
			Always = 1
		}

		[SerializeField]
		private PhysicalUICanvasPointer _canvasPointer;

		[SerializeField]
		private GameObject? _hitPointMarker;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private Gradient _hoveringSelectableGradient;

		[SerializeField]
		private Gradient _noSelectableGradient;

		[SerializeField]
		private bool _queryPhysicsColliders;

		[SerializeField]
		private VisibilityMode _visibilityMode;

		private RaycastHit _lastHit;

		private Vector3 _cachedEndPosition;

		private Ray _cachedRay;

		private int _hitCount;

		private bool _hasHitPointMarker;

		private void LateUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandlePressInternal(GameObject pressedObject)
		{
		}

		private void OnPointerEnteredCanvas()
		{
		}

		private void OnPointerExitCanvas()
		{
		}

		private void OnPointerUpdated(PointerEventData data, float pointerLength)
		{
		}

		private void ShowRay(bool show)
		{
		}

		private void ShowHitPointMarker(bool show)
		{
		}

		private void ShootRay(float dist, out RaycastHit hit)
		{
			hit = default(RaycastHit);
		}
	}
}
