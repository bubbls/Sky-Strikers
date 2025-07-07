using UnityEngine;
using moveen.utils;

namespace moveen.example
{
	public class SoundStarter : MonoBehaviour, Startable
	{
		[BindOrLocalWarning]
		public AudioSource audioSource;

		[BindWarning]
		[Tooltip("Audio clip to play")]
		public AudioClip audioClip;

		[Tooltip("Play from position (seconds)")]
		public float startAt;

		[Tooltip("Finish at position (seconds)")]
		public float finishAt;

		[Range(0f, 1f)]
		public float volume;

		private void OnEnable()
		{
		}

		public void start()
		{
		}
	}
}
