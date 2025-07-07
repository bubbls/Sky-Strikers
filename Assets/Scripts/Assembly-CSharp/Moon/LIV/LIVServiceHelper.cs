using UnityEngine;

namespace Moon.LIV
{
	public class LIVServiceHelper : MonoBehaviour
	{
		[SerializeField]
		private uint _framerate;

		[SerializeField]
		private uint _bitrate;

		[SerializeField]
		private uint _height;

		[SerializeField]
		private uint _width;

		[SerializeField]
		private uint _audioBitrate;

		[SerializeField]
		[Tooltip("Ask for microphone permissions on Android")]
		private bool _askForMicPermissions;

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}
	}
}
