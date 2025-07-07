using UnityEngine;

namespace Autohand
{
	[HelpURL("https://app.gitbook.com/s/5zKO0EvOjzUDeT2aiFk3/auto-hand/hand/finger-component")]
	public class Finger : MonoBehaviour
	{
		[Tooltip("This transfrom will represent the tip/stopper of the finger")]
		[Header("Tips")]
		public Transform tip;

		[Tooltip("This determines the radius of the spherecast check when bending fingers")]
		public float tipRadius;

		[Tooltip("This will offset the fingers bend (0 is no bend, 1 is full bend)")]
		[Range(0f, 1f)]
		public float bendOffset;

		public float fingerSmoothSpeed;

		[HideInInspector]
		public float secondaryOffset;

		private float currBendOffset;

		private float bend;

		[SerializeField]
		private Quaternion[] minGripRotPose;

		[SerializeField]
		private Vector3[] minGripPosPose;

		[SerializeField]
		private Quaternion[] maxGripRotPose;

		[SerializeField]
		private Vector3[] maxGripPosPose;

		[SerializeField]
		private Transform[] fingerJoints;

		private float lastHitBend;

		private Collider[] results;

		private float _cachedOffsetValue;

		public Transform[] FingerJoints => null;

		public void Update()
		{
		}

		public bool BendFingerUntilHit(int steps, int layermask)
		{
			return false;
		}

		public bool UpdateFingerBend(float bend, int layermask)
		{
			return false;
		}

		private void UpdateFinger()
		{
		}

		public void UpdateFinger(float bend)
		{
		}

		public void SetFingerBend(float bend)
		{
		}

		public void SetCurrentFingerBend(float bend)
		{
		}

		private void SlowBend()
		{
		}

		[ContextMenu("ResetBend")]
		public void ResetBend()
		{
		}

		[ContextMenu("Grip")]
		public void Grip()
		{
		}

		public float GetLastHitBend()
		{
			return 0f;
		}

		[ContextMenu("Set Open Finger Pose")]
		public void SetMinPose()
		{
		}

		[ContextMenu("Set Closed Finger Pose")]
		public void SetMaxPose()
		{
		}

		public void CopyPose(Finger finger)
		{
		}

		public bool IsMinPoseSaved()
		{
			return false;
		}

		public bool IsMaxPoseSaved()
		{
			return false;
		}

		public float GetCurrentBend()
		{
			return 0f;
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
