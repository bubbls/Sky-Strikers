using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon
{
	public class PlaySwingFx : MonoBehaviour
	{
		[SerializeField]
		private float _speedThreshold;

		[SerializeField]
		private float _lowSpeedThreshold;

		[SerializeField]
		private VelocityTracker _tracker;

		private bool _played;

		private float _speed;

		public event Action<Vector3> RequestPlaySwingFx
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
