using Chamber8.Framework.Common;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

namespace Moon.Arena
{
	public class GlobalEffects : SingleMonoBehaviour<GlobalEffects, InSceneSingleMonoBehaviourSettings>
	{
		private const float DefaultGoalFxRange = 0.5f;

		private static readonly int _propBallPosition;

		private static readonly int _propTimeSimulation;

		private static readonly int _gTeamRange;

		[SerializeField]
		private Material _airWallMaterial;

		[SerializeField]
		private ParticleSystem _matchEndConfetti;

		[SerializeField]
		private float _arenaArrowsChangeSpeed;

		[SerializeField]
		private Gradient _teamOneConfettiGradient;

		[SerializeField]
		private Gradient _teamTwoConfettiGradient;

		[SerializeField]
		private Gradient _matchDrawConfettiGradient;

		[SerializeField]
		private ArenaFieldChangingWarningFX _fieldChangeWarningFx;

		private GlobalKeyword _disableGroup;

		private float _targetArenaArrowRange;

		private float _currentArenaArrowRange;

		private bool _changeArenaArrowRange;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void UpdateBallVisualPosition(Vector3 position)
		{
		}

		public void SetBallHitPosition(Vector3 hitPosition, bool hasEffect = true)
		{
		}

		public void EnableGroupColor(bool enable)
		{
		}

		private void OnDisable()
		{
		}

		public void PlayGoalFx(TeamNo teamNo)
		{
		}

		[UsedImplicitly]
		public void StopGoalFx()
		{
		}

		public void PlayEndMatchFx(TeamNo winningTeam)
		{
		}

		private void SetConfettiColorForTeam(TeamNo teamNo)
		{
		}

		public void StopEndMatchFx()
		{
		}

		private void SetTargetArrowRange(float target)
		{
		}

		public void ToggleFieldChangeWarningFX(bool show)
		{
		}
	}
}
