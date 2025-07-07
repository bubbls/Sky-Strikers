using UnityEngine;

namespace Moon.Mission
{
	public class TaskCompletionBeamHitPosition : MonoBehaviour
	{
		[SerializeField]
		private Transform _beam;

		[SerializeField]
		private Transform _sphere;

		[SerializeField]
		private MeshRenderer _sphereRenderer;

		[SerializeField]
		private float _sphereRadius;

		private Material _material;

		private readonly int _dissolvePoint;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
