using System;
using UnityEngine;
using moveen.descs;
using moveen.utils;

namespace moveen.example
{
	public class Step2Event : MonoBehaviour
	{
		[Tooltip("Target Step2 component. If null, will be looked for on this GameObject")]
		public MoveenStep2 step2;

		[ReadOnly]
		public bool wasAtGround;

		[NonSerialized]
		private Startable[] _startables;

		[NonSerialized]
		private ParticleSystem[] particleSystems;

		[Tooltip("GameObject that conatins Startables to execute when the event is happening. If not defined - Starables will be collected from the current GameObject")]
		public Transform effects;

		private void OnEnable()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
