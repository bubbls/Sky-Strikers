using UnityEngine;

namespace Moon.Common.Rendering
{
	public class Billboarding : MonoBehaviour
	{
		public delegate bool GetFacingTargetDelegate(out Transform target);

		public static GetFacingTargetDelegate GetFacingTarget;

		[SerializeField]
		private bool _lockY;

		private Transform _transform;

		private Transform _facingTarget;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public static bool DefaultGetFacingTarget(out Transform target)
		{
			target = null;
			return false;
		}
	}
}
