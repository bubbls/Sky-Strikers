using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon
{
	public class Hittable : MonoBehaviour
	{
		public delegate void OnHitEvent(MHitter hitter, HittableHitInfo hitInfo);

		[SerializeField]
		private float _cooldown;

		private float _nextHitTime;

		private MHitter _lastHitter;

		private float _cachedTime;

		public event OnHitEvent OnHit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool RaiseOnHit(MHitter hitter, HittableHitInfo hitInfo)
		{
			return false;
		}
	}
}
