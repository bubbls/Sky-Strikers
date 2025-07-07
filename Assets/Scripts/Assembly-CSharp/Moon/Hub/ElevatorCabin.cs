using System;
using DG.Tweening;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Hub
{
	public class ElevatorCabin : MonoBehaviour
	{
		[SerializeField]
		private Transform _doorPivot;

		[SerializeField]
		private SoundInfo _sfxDoorClose;

		[SerializeField]
		private Transform _referencePoint;

		private Tween _tween;

		protected bool IsMoving { get; private set; }

		private void OnDestroy()
		{
		}

		protected void OpenDoor(Action complete, bool immediate = false)
		{
		}

		protected void CloseDoor(Action complete, bool immediate = false)
		{
		}

		protected void DontDestroyOnLoad()
		{
		}

		protected void Destroy()
		{
		}
	}
}
