using DP.Takeaway.Utils;
using Moon.Arena;
using Photon.Voice.Fusion;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerAvatarHeadVisual : PlayerAvatarVisual
	{
		[SerializeField]
		private SpeakerVisualizer _speakerVisualizer;

		private Transform _rotationFollowTarget;

		[SerializeField]
		private Transform _nameTagFollowTarget;

		public AvatarHeadVisualTheme AvatarHeadVisualTheme { get; private set; }

		public override int ThemeInt => 0;

		public Transform NameTagFollowTarget => null;

		protected override void SetTheme(int theme)
		{
		}

		protected override void InitializeInternal()
		{
		}

		private void LateUpdate()
		{
		}

		protected override PlayerMaterial GetPlayerMaterial(TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public override void SetTeamColor(TeamNo teamNo)
		{
		}

		public void SetRotationFollowTarget(Transform target)
		{
		}

		public void SetVoiceNetworkObject(VoiceNetworkObject voiceNetworkObject)
		{
		}

		protected override void HandleCommandExecution(ICommand command)
		{
		}

		protected override void TryAssignCommonComponentsInternal()
		{
		}
	}
}
