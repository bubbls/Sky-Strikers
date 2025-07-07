using UnityEngine;

namespace Moon.Arena
{
	public class ProjectionOnGround : MonoBehaviour
	{
		[SerializeField]
		private MBall _ball;

		[SerializeField]
		private float _groundHeight;

		[SerializeField]
		private float _sizeMultiplier;

		[SerializeField]
		private Transform _pivot;

		[SerializeField]
		private Transform _scalablePivot;

		private bool _shouldShow;

		private Vector3 _targetScale;

		private void Awake()
		{
		}

		private void Ball_OnSpawned()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(bool show)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
