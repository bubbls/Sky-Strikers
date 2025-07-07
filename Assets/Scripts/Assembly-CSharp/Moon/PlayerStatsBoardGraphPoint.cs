using UnityEngine;

namespace Moon
{
	public class PlayerStatsBoardGraphPoint : MonoBehaviour
	{
		[SerializeField]
		private Transform _startPoint;

		[SerializeField]
		private Transform _endPoint;

		[SerializeField]
		private Transform _movePoint;

		[SerializeField]
		private float _maxValue;

		private float _configuredMaxValue;

		public Vector3 Position => default(Vector3);

		public void SetPoint(float value, float configuredMaxValue)
		{
		}

		public void SetPoint(Vector3 position)
		{
		}
	}
}
