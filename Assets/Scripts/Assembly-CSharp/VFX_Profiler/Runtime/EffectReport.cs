using System;
using UnityEngine;

namespace VFX_Profiler.Runtime
{
	[Serializable]
	public class EffectReport
	{
		public GameObject target;

		public AnimationCurve particleCountCurve;

		public AnimationCurve drawCallCurve;

		public AnimationCurve overdrawCurve;

		public float totalTime;

		public int textureCount;

		public int memorySize;

		public int particleSystemCount;

		public int maxDrawCall;

		public int maxParticleCount;

		public int pixelRate;

		public int noSupportedCullingReason;

		public int noRegularReason;

		public bool foldout;
	}
}
