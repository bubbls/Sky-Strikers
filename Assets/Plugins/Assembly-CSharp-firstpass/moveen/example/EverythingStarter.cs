using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace moveen.example
{
	public class EverythingStarter : MonoBehaviour, Startable
	{
		[Tooltip("If false - looks for startable in target GameObject only. If enabled - in its hierarchy too")]
		public bool lookInChildren;

		[Tooltip("Target GameObject. If null - considered this GameObject")]
		[FormerlySerializedAs("effects")]
		public Transform target;

		[NonSerialized]
		private ParticleSystem[] particleSystems;

		[NonSerialized]
		private Startable[] startables;

		private void Awake()
		{
		}

		public void start()
		{
		}
	}
}
