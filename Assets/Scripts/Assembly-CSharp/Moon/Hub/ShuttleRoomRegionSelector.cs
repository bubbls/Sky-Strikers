using System;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Moon.Bootstrap;
using Moon.Framework.Base;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class ShuttleRoomRegionSelector : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textRegion;

		private IMessageSubscriber _subscriber;

		public PlayFabRegion SelectedRegion { get; private set; }

		public event Action OnRegionChanged
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

		private int HandleLatencyUpdated(IMessage<object> arg)
		{
			return 0;
		}

		private void UpdateRegionSelections()
		{
		}

		private static string GetRegionText(Latency selectedLatency)
		{
			return null;
		}

		private static Color GetRegionColor(Latency latency)
		{
			return default(Color);
		}

		public static Color GetLatencyColor(int latency)
		{
			return default(Color);
		}

		public void ChangeRegion(bool next)
		{
		}
	}
}
