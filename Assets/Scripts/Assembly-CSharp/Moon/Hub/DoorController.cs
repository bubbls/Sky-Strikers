using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Hub
{
	public class DoorController : MonoBehaviour
	{
		[SerializeField]
		private List<ManualToggle> _doorParts;

		[SerializeField]
		private bool _isOpen;

		[SerializeField]
		private SoundInfo _sfxToggle;

		[SerializeField]
		private Transform _sfxPosition;

		[SerializeField]
		private bool _listenToDeadzone;

		[SerializeField]
		private Trigger _autoTrigger;

		private bool? _isOpenWhenStart;

		private bool _invertAfterStart;

		private float _invertDelay;

		private int _animatedPart;

		private IMessageSubscriber _sub;

		private bool _autoTriggerEnabled;

		public bool IsOpen => false;

		public event Action OnStarted
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

		public event Action OnCompleted
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleLocalPlayerTouchDeadZone(IMessage<object> message)
		{
			return 0;
		}

		private void Start()
		{
		}

		private void AutoTriggerOnOnEnter(Collider col)
		{
		}

		private void AutoTrigger_OnExit(Collider col)
		{
		}

		public void EnableAutoTrigger()
		{
		}

		public void DisableAutoTrigger()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void OpenDoor()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void CloseDoor()
		{
		}

		public void Toggle(bool open, bool immediate)
		{
		}

		private void OnDoorPartAnimated()
		{
		}
	}
}
