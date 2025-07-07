using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon
{
	public class LookingActivator : MonoBehaviour
	{
		public const string OnActivated = "OnActivated";

		[SerializeField]
		private LayerMask _layerMask;

		[SerializeField]
		private float _maxDistance;

		private readonly RaycastHit[] _hits;

		private Transform _transform;

		private int _hitsCount;

		private readonly Cooldown _cooldown;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
