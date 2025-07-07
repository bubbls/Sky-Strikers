using DG.Tweening;
using UnityEngine;

namespace Moon
{
	public class GlitchAmmo : MonoBehaviour
	{
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[SerializeField]
		private Collider _collider;

		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private float _releaseForce;

		[SerializeField]
		private float _releaseTorque;

		[SerializeField]
		private float _despawnDelay;

		private Sequence _curSequence;

		private Vector3 _startPosition;

		private Vector3 _endPosition;

		private bool _shouldIdle;

		private float _idleSpeed;

		private float _idleTimeFactor;

		public void SetMaterial(Material material)
		{
		}

		public void Release()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public Tween GetShiftTween(Vector3 targetPos, Vector3 targetRotation, float duration)
		{
			return null;
		}

		public void Idle(Vector3 startPosition, Vector3 endPosition, float speed)
		{
		}

		public void StopIdle()
		{
		}

		private void LateUpdate()
		{
		}

		private void KillTweens()
		{
		}
	}
}
