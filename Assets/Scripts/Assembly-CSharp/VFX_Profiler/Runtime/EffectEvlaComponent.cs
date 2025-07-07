using System.Reflection;
using UnityEngine;

namespace VFX_Profiler.Runtime
{
	public class EffectEvlaComponent : MonoBehaviour
	{
		public AnimationCurve particleCount;

		public AnimationCurve drawCall;

		public AnimationCurve overdraw;

		public bool loop;

		[Range(1f, 10f)]
		public int runtime;

		private EffectOverdraw _effectEvla;

		private ParticleSystem[] _particleSystems;

		private MethodInfo _calculateEffectUIDataMethod;

		private int _particleCount;

		private int _maxParticleCount;

		private int _maxDrawCall;

		private int _maxOverdraw;

		private int _textureCount;

		private int _memorySize;

		private int _particleSystemCount;

		private int _noSupportedCullingReason;

		private EffectEvlaCurve _curveParticleCount;

		private EffectEvlaCurve _curveDrawCallCount;

		private EffectEvlaCurve _curveOverdraw;
	}
}
