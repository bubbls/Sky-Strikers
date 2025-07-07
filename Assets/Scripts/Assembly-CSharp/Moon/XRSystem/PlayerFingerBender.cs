using Autohand;
using UnityEngine;

namespace Moon.XRSystem
{
	public class PlayerFingerBender : MonoBehaviour
	{
		[SerializeField]
		private float[] _bendOffsets;

		private Finger[] _fingers;

		private float _lastAxisValue;

		private float _currAxisValue;

		public void SetFingers(Finger[] fingers)
		{
		}

		public void SetValue(float value)
		{
		}

		private void LateUpdate()
		{
		}

		public void Reset()
		{
		}
	}
}
