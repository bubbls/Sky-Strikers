using UnityEngine;

namespace VFX_Profiler.Runtime
{
	public static class EffectEvlaUtility
	{
		public static float GetMaxValue(this ParticleSystem.MinMaxCurve minMaxCurve)
		{
			return 0f;
		}

		public static float GetMinValue(this ParticleSystem.MinMaxCurve minMaxCurve)
		{
			return 0f;
		}

		public static float GetMaxValue(this AnimationCurve curve)
		{
			return 0f;
		}

		public static float GetMinValue(this AnimationCurve curve)
		{
			return 0f;
		}

		public static float GetDuration(this ParticleSystem particle, bool allowLoop = false)
		{
			return 0f;
		}

		public static float GetParticleDuration(this GameObject gameObject, bool includeChildren = true, bool includeInactive = false, bool allowLoop = false)
		{
			return 0f;
		}
	}
}
