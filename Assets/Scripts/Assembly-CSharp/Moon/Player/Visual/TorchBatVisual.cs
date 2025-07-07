using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class TorchBatVisual : PrimeBatVisual
	{
		[SerializeField]
		private AudioSource _torchAudioSource;

		[SerializeField]
		private GameObject[] _particlesToHideWhenAttachedToHand;

		[SerializeField]
		private ParticleSystem[] _FireTrailParticles;

		private TorchVfxController _torchVfxController;

		private IMessageSubscriber _messageSubscriber;

		protected override void InitializeVisualOnHand()
		{
		}

		private void HideFireTrailParticles()
		{
		}

		protected override void HandleShow()
		{
		}

		protected override void HandleHide(bool instantly)
		{
		}

		private void OnDestroy()
		{
		}

		private int HandlePlayerLocomotionMessage(IMessage<PlayerLocomotionMessage> message)
		{
			return 0;
		}

		private void PlayFireParticles()
		{
		}

		private void StopFireParticles()
		{
		}

		private void DestroyTorchVfx()
		{
		}

		private void TryCreateTorchTrail()
		{
		}

		private bool IsRightHand()
		{
			return false;
		}
	}
}
