using UnityEngine;
using UnityEngine.Audio;

namespace Moon.Arena
{
	public class CrowdVolumeController : MonoBehaviour
	{
		private const string CrowdVolume = "CrowdVolume";

		[SerializeField]
		private LocalPlayerArenaLocationChecker _localPlayerArenaLocationChecker;

		[SerializeField]
		private AudioMixerGroup _crowdAudioGroup;

		[SerializeField]
		private AnimationCurve _distanceFromFieldVolumeCurve;

		[SerializeField]
		private Transform _fieldCheckPoint;

		private bool _checkPlayerOnField;

		private float _distance;

		private float _curVolume;

		private Vector3 _zOnlyPlayerPos;

		private Vector3 _zOnlyFieldPos;

		public void SetupCrowdVolume()
		{
		}

		private void Start()
		{
		}

		private void OnArenaFieldStatusChanged(bool hasPlayer)
		{
		}

		private void LateUpdate()
		{
		}

		private void TryStartCheckingPlayerOnField(bool hasPlayer)
		{
		}
	}
}
