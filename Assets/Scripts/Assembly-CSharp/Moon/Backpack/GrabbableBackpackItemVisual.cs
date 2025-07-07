using System;
using UnityEngine;

namespace Moon.Backpack
{
	public class GrabbableBackpackItemVisual : MonoBehaviour
	{
		[Serializable]
		public class GrabbableBackItemVisualConfig
		{
			public bool UseFixedGrabRotation;

			public Vector3 LeftHandFixedGrabRotation;

			public Vector3 RightHandFixedGrabRotation;

			public Vector3 GrabPositionOffset;
		}

		[SerializeField]
		private GameObject _selectIndicator;

		[SerializeField]
		private GrabbableBackItemVisualConfig _visualConfig;

		[Header("Optional")]
		[SerializeField]
		private Animator _animator;

		public GrabbableBackItemVisualConfig VisualConfig => null;

		public void ToggleSelectIndicator(bool enable)
		{
		}

		public void PlayAnimation(string stateName)
		{
		}

		public void ResetAnimation(string stateName)
		{
		}
	}
}
