using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.AI.VisualScripting
{
	public class OverlapShapeDesc : MonoBehaviour
	{
		[SerializeField]
		private HitboxTypes _type;

		[SerializeField]
		private Vector3 _offset;

		[SerializeField]
		private float _sphereRadius;

		[SerializeField]
		private Vector3 _boxExtents;

		[SerializeField]
		private Color _gizmosColor;

		private Transform _transform;

		public HitboxTypes Type => default(HitboxTypes);

		public Vector3 Offset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float SphereRadius => 0f;

		public Vector3 BoxExtents
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Position => default(Vector3);

		private void Awake()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public bool Contains(Vector3 worldPosition, out float distance)
		{
			distance = default(float);
			return false;
		}

		public bool Contains(Vector3 worldPosition)
		{
			return false;
		}

		public Vector3 GetRandomPointInBounds()
		{
			return default(Vector3);
		}

		[Preserve]
		public bool RandomPointInsideCastDownOnLocomotionLayers(float distance, out Vector3 pointCastDown)
		{
			pointCastDown = default(Vector3);
			return false;
		}

		public void CopyFrom(OverlapShapeDesc other)
		{
		}

		public void SetOverlapShapeDescData(OverlapShapeDescData osdData)
		{
		}

		public OverlapShapeDescData GetOverlapShapeDescData()
		{
			return default(OverlapShapeDescData);
		}

		public Vector3 GetClosestPointInBounds(Vector3 worldPosition)
		{
			return default(Vector3);
		}
	}
}
