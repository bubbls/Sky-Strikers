using System;
using Moon.Arena;
using SVGImporter;
using UnityEngine;

namespace Moon
{
	public class SpeakerVisualIndicatorWithImage : MonoBehaviour, ISpeakerVisual
	{
		[Serializable]
		private class VolumeLevelSvg
		{
			public float TargetSpeedPercentage;

			public SVGAsset Svg;
		}

		[SerializeField]
		private SVGImage _svgImage;

		[SerializeField]
		private VolumeLevelSvg[] _volumeLevelSvgs;

		[SerializeField]
		private float _localPlayerVolumeMultiplier;

		private bool _isLocalPlayerVisual;

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
