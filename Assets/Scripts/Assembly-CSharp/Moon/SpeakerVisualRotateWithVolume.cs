using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class SpeakerVisualRotateWithVolume : MonoBehaviour, ISpeakerVisual
	{
		[SerializeField]
		private PlayerMaterials _playerMaterials;

		[SerializeField]
		private Transform _rotatePoint;

		[SerializeField]
		private float _valueDropSpeed;

		[SerializeField]
		private float _maxAngle;

		[SerializeField]
		private float _angleDropSpeed;

		[SerializeField]
		private float _offset;

		private Vector3 _initialAngles;

		private float _currValue;

		private float _currAngle;

		private bool _isInitialized;

		void ISpeakerVisual.Initialize(bool isLocalPlayerVisual)
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
