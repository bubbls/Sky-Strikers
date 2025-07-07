using Photon.Voice;
using Photon.Voice.Unity;
using UnityEngine;

namespace Moon.MultiPlay
{
	[RequireComponent(typeof(Speaker))]
	public class SpeakerWaveformReader : MonoBehaviour, IVoiceVolumeReader
	{
		private Speaker _speaker;

		private bool _attached;

		public float Amplitude { get; private set; }

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void TryAttachToRemoteVoice()
		{
		}

		private void DetachFromRemoteVoice()
		{
		}

		private void HandleOnRemoteVoiceRemoved()
		{
		}

		private void Update()
		{
		}

		private void HandleFrameDecoded(FrameOut<float> frameOut)
		{
		}
	}
}
