using UnityEngine;

namespace Moon.Profiler
{
	public class CameraFollow : MonoBehaviour
	{
		public Camera followCamera;

		public float distance;

		public float smoothSpeed;

		private Vector3 _currentForward;

		private void Awake()
		{
		}

		private Camera GetFollowCamera()
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
