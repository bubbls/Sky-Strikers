using DP.Takeaway.Utils;
using Moon.Arena;
using Moon.MultiPlay;
using Photon.Voice.Fusion;
using UnityEngine;

namespace Moon
{
	public class SpeakerVisualizer : MonoBehaviour, ICommandExecutor
	{
		private bool _isLocalPlayerVisual;

		private VoiceNetworkObject _voiceNetworkObject;

		private IVoiceVolumeReader _reader;

		private ISpeakerVisual[] _speakerVisuals;

		public void Initialize(bool isLocalPlayerVisual)
		{
		}

		public void SetVoiceNetworkObject(VoiceNetworkObject voiceNetworkObject)
		{
		}

		private void TryConnectToReader()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public void ApplyTeamChangedVisuals(PlayerMaterial material, TeamNo teamNo)
		{
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}
	}
}
