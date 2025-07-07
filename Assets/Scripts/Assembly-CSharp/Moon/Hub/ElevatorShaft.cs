using System;
using DG.Tweening;
using DP.Takeaway.Sound;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Hub
{
	public class ElevatorShaft : MonoBehaviour
	{
		[SerializeField]
		private DoorController _topDoor;

		[SerializeField]
		private DoorController _bottomDoor;

		[SerializeField]
		private Transform _pivot;

		[SerializeField]
		private Transform _topPivot;

		[SerializeField]
		private Transform _bottomPivot;

		[SerializeField]
		private float _startDelay;

		[SerializeField]
		private float _animDuration;

		[SerializeField]
		private float _stopDelay;

		[SerializeField]
		private bool _startFromBottom;

		[SerializeField]
		private SoundInfo _sfxStart;

		[SerializeField]
		private SoundInfo _sfxRunning;

		[SerializeField]
		private SoundInfo _sfxStop;

		[SerializeField]
		private Transform _sfxPosition;

		private Sequence _sequence;

		private int _soundId;

		private void Start()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void SnapToTop()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void SnapToBottom()
		{
		}

		private void Snap()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void Run(Action beforeOpenDoor = null)
		{
		}

		private void RunInternal(Transform end, Action beforeOpenDoor)
		{
		}

		public void ToggleInDoor(bool open, bool immediate)
		{
		}

		private void ToggleOutDoor(bool open, bool immediate)
		{
		}

		public void OpenOutDoor()
		{
		}
	}
}
