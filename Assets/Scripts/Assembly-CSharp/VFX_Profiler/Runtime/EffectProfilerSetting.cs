using System.Collections.Generic;
using UnityEngine;

namespace VFX_Profiler.Runtime
{
	[CreateAssetMenu(menuName = "VFX_Profiler/Setting/Create Profiler Setting")]
	public class EffectProfilerSetting : ScriptableObject
	{
		[Header("测试环境")]
		public string directoryPath;

		public int fps;

		public int rtWidth;

		public int rtHeight;

		[Header("测试阈值")]
		public float totalTime;

		public int maxTextureCount;

		public int maxMemorySize;

		public int maxParticleSystemCount;

		public int maxDrawCall;

		public int maxParticleCount;

		public int maxPixelRate;

		public bool supportCulling;

		[Header("测试结果")]
		public EffectReport singleReport;

		public List<EffectReport> effectReports;
	}
}
