using System;

namespace VFX_Profiler.Runtime
{
	[Flags]
	public enum NoRegularReason
	{
		None = 0,
		TotalTime = 1,
		TextureCount = 2,
		MemorySize = 4,
		ParticleSystemCount = 8,
		MaxDrawCall = 0x10,
		MaxParticleCount = 0x20,
		PixelRate = 0x40,
		NoSupportedCullingReason = 0x80
	}
}
