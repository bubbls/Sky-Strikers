using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Game;
using Moon.Interaction;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVCameraLocalGrabbable : LocalGrabbable
	{
		[SerializeField]
		private Trigger _areaTrigger;

		private static readonly HapticImpulse _hapticImpulse;

		public Vector3 Position { get; private set; }

		public event Action OnLeftCameraArea
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnExitArea(Collider other)
		{
		}

		private void Update()
		{
		}

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
		{
		}
	}
}
