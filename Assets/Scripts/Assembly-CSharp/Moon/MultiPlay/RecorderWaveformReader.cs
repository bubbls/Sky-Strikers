using Photon.Voice.Unity;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.MultiPlay
{
	[RequireComponent(typeof(Recorder))]
	public class RecorderWaveformReader : MonoBehaviour, IVoiceVolumeReader
	{
		[SerializeField]
		private float _voiceDetectionThreshold;

		[SerializeField]
		private float _ampMultiplier;

		private Recorder _recorder;

		private bool _hasRecorder;

		public float Amplitude { get; private set; }

		private void Awake()
		{
		}

		[Preserve]
		private void PhotonVoiceCreated()
		{
		}

		private void Update()
		{
		}
	}
}
