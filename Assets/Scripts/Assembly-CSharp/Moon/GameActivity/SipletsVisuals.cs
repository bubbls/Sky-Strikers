using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.GameActivity
{
	[CreateAssetMenu(fileName = "SipletsVisuals", menuName = "Moon/Game Activity/Create SipletsVisuals")]
	public class SipletsVisuals : SingleScriptableObject<SipletsVisuals, DefaultResourcePathProvider<SipletsVisuals>>
	{
		[SerializeField]
		private GameObject _fxSipletsAbsorbingPrefab;

		[SerializeField]
		private GameObject _fxSipletsAbsorbingTrailPrefab;

		[SerializeField]
		private float _trialParticleMovingSpeed;

		[SerializeField]
		private float _pathDistortionAmp;

		[SerializeField]
		private float _pathDistortionFreq;

		public GameObject FxSipletsAbsorbingPrefab => null;

		public GameObject FxSipletsAbsorbingTrailPrefab => null;

		public float TrialParticleMovingSpeed => 0f;

		public float PathDistortionAmp => 0f;

		public float PathDistortionFreq => 0f;
	}
}
