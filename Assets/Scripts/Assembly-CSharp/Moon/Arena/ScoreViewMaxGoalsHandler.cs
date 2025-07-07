using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ScoreViewMaxGoalsHandler : ScoreViewMaxGoalsHandlerBase
	{
		[SerializeField]
		private TMP_Text _infoText;

		[SerializeField]
		private ArenaScreenMesh _arenaScreenMesh;

		private bool _isViewActive;

		private Cooldown _cooldown;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		public override void HandleOnViewEntered(object viewData)
		{
		}

		private void LateUpdate()
		{
		}

		public override void HandleOnViewExited()
		{
		}
	}
}
