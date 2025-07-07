using System;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public class ExplosionConfiguration : ICloneable
	{
		[Serializable]
		public class ForceConfig : ICloneable
		{
			public AnimationCurve PowerCurve;

			public AnimationCurve LiftCurve;

			public object Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class ForceConfigLookup : SerializableDictionary<string, ForceConfig>, ICloneable
		{
			public object Clone()
			{
				return null;
			}
		}

		public float ExplosionRadius;

		public float ExplosionForce;

		public float ExplosionDuration;

		public int ExplosionExecutionTicksCount;

		public AnimationCurve ExplosionForceCurve;

		public ForceMode ExplosionForceMode;

		public float ServerDespawnDelay;

		public ForceConfigLookup ExplosionForceConfigLookup;

		public object Clone()
		{
			return null;
		}
	}
}
