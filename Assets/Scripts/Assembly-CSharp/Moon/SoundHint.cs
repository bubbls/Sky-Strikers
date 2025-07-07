using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using Moon.Profiler;
using UnityEngine;

namespace Moon
{
	public class SoundHint : MonoBehaviour
	{
		[SerializeField]
		private SoundInfo _sfxEnableProfilerLog;

		private IMessageSubscriber[] _subscribers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleEnableProfilerLogMessage(IMessage<ProfilerLogMessage> arg)
		{
			return 0;
		}
	}
}
