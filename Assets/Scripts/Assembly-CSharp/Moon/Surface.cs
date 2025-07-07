using UnityEngine;

namespace Moon
{
	public class Surface : MonoBehaviour
	{
		[SerializeField]
		private float _slipPercentage;

		[SerializeField]
		private float _bounceFactor;

		public float SlipPercentage => 0f;

		public float BounceFactor => 0f;
	}
}
