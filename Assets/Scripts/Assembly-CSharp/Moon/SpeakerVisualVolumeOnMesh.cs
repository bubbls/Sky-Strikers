using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class SpeakerVisualVolumeOnMesh : MonoBehaviour, ISpeakerVisual
	{
		private static readonly int _team2;

		private static readonly int _volume;

		[SerializeField]
		private AnimationCurve _volumeAnimationCurve;

		[SerializeField]
		private float _lerpMultiplier;

		[SerializeField]
		private MeshRenderer _headMesh;

		private float _targetValue;

		private bool _isInitialized;

		void ISpeakerVisual.Initialize(bool isLocalPlayerVisual)
		{
		}

		private void OnDestroy()
		{
		}

		void ISpeakerVisual.ApplyTeamChangedVisuals(PlayerMaterial material, TeamNo teamNo)
		{
		}

		void ISpeakerVisual.UpdateInternal(float value)
		{
		}
	}
}
