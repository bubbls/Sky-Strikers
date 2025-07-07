using System;
using UnityEngine;
using moveen.utils;

namespace moveen.example
{
	public class FireControl2 : MonoBehaviour
	{
		[Tooltip("FocusGrabber defines if this component will react player's input or not. If not defined - component grabs input")]
		public FocusGrabber focusGrabber;

		[Tooltip("If true - component will start its events only once per mouse click. If false - component can shoot continuously")]
		public bool fireOnClick;

		[Tooltip("Input action name")]
		public string actionCode;

		[Tooltip("Component will not shoot more often than this amount of seconds")]
		public float cooldown;

		[ReadOnly]
		public float curCooldown;

		[ReadOnly]
		public bool justFired;

		[NonSerialized]
		private ParticleSystem[] particleSystems;

		[NonSerialized]
		private Startable[] _startables;

		public Transform effects;

		private void OnEnable()
		{
		}

		private void beginFire()
		{
		}

		private void Update()
		{
		}
	}
}
