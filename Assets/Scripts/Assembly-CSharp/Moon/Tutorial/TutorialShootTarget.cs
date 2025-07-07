using UnityEngine;
using UnityEngine.Events;

namespace Moon.Tutorial
{
	public class TutorialShootTarget : MissileHittable
	{
		[SerializeField]
		private UnityEvent _onHitEvent;

		public override void OnHit()
		{
		}
	}
}
