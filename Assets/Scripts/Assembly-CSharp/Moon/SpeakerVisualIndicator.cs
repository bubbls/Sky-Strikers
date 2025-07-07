using System;
using Moon.Arena;
using SVGImporter;
using UnityEngine;

namespace Moon
{
	public class SpeakerVisualIndicator : MonoBehaviour, ISpeakerVisual
	{
		[Serializable]
		private class VolumeLevelSvg
		{
			public float TargetSpeedPercentage;

			public SVGAsset Svg;
		}

		[SerializeField]
		private SVGRenderer _svgRenderer;

		[SerializeField]
		private VolumeLevelSvg[] _volumeLevelSvgs;

		[SerializeField]
		private float _localPlayerVolumeMultiplier;

		private Transform _lookAtTransform;

		private bool _hasLookAt;

		private bool _isLocalPlayerVisual;

		void ISpeakerVisual.Initialize(bool isLocalPlayerVisual)
		{
		}

		private void LateUpdate()
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
