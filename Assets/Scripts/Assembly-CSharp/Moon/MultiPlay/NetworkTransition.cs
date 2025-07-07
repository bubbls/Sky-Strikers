using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Bootstrap;
using Moon.Player;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class NetworkTransition : MonoBehaviour
	{
		[Serializable]
		public class TransitionNotification
		{
			public MatchmakingStatus status;

			public NotificationMessage messageSetting;
		}

		public Material skybox;

		[CurveRange(0f, 0f, 1f, 1f, EColor.Clear)]
		public AnimationCurve stretchCurve;

		[CurveRange(0f, 0f, 1f, 1f, EColor.Clear)]
		public AnimationCurve switchCurve;

		public float stretchSpeed;

		public float switchSpeed;

		[SerializeField]
		private List<TransitionNotification> _notifications;

		private float _stretchProgress;

		private float _switchProgress;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private bool _transfer;

		private bool _reverse;

		private void Awake()
		{
		}

		private int HandleMatchmakingStatusUpdate(IMessage<object> _)
		{
			return 0;
		}

		private int HandleMPlayerSpawnedMessage(IMessage<MPlayer> message)
		{
			return 0;
		}

		private void Update()
		{
		}

		private void Transfer()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void DoTransfer()
		{
		}

		private void SendNotification(MatchmakingStatus status)
		{
		}
	}
}
