using UnityEngine;

namespace moveen.example
{
	public class HitCalculator1 : MonoBehaviour, Startable
	{
		[Tooltip("Hitscanner determines current target on the sight. If not stated - it will be searched for on this GameObject")]
		public Hitscanner hitscanner;

		[Tooltip("Amount of force to be applied to the target")]
		public float hitForce;

		private void Awake()
		{
		}

		public void start()
		{
		}
	}
}
