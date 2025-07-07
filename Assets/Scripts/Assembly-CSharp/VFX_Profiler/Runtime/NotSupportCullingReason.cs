using System;

namespace VFX_Profiler.Runtime
{
	[Flags]
	public enum NotSupportCullingReason
	{
		None = 0,
		EnableCollision = 1,
		EnableEmissionRateOverDistanceNonZero = 2,
		EnableExternalForces = 4,
		EnableForceOverLifetimeNotSupportProcedural = 8,
		EnableInheritVelocityNotSupportProcedural = 0x10,
		EnableNoise = 0x20,
		EnableRotationBySpeedNotSupportProcedural = 0x40,
		EnableRotationOverLifetimeNotSupportProcedural = 0x80,
		EnableParticleSystemShapeRandom = 0x100,
		EnableSubEmitters = 0x200,
		EnableTrails = 0x400,
		EnableTrigger = 0x800,
		EnableVelocityOverLifetimeNotSupportProcedural = 0x1000,
		EnableLimitVelocityOverLifetime = 0x2000,
		SimulationSpaceNotLocal = 0x4000,
		GravityModifierMultiplierNonZero = 0x8000
	}
}
