using System;
using Fusion;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public class MissileLifetimeData
	{
		public PlayerRef InputAuthority;

		public NetworkRunner Runner;

		public Vector3 FirePosition;

		public Vector3 FireDirection;

		public Tick FireTick;

		public Tick ExplosionTargetTick;
	}
}
