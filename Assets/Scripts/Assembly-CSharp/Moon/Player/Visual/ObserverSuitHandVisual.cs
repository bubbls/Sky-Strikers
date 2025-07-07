using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class ObserverSuitHandVisual : PlayerSuitHandVisual
	{
		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private Transform _padInteractor;

		[SerializeField]
		private Gradient _interactableColor;

		[SerializeField]
		private Gradient _idleColor;

		public Vector3 PadInteractorForward => default(Vector3);

		protected override void InitializeInternal()
		{
		}

		public override void SetTeamColor(TeamNo teamNo)
		{
		}

		public void TogglePadInteractor(bool enable)
		{
		}

		public void ShowAsInteractable(Vector3 interactablePosition)
		{
		}

		public void ShowAsIdle(Vector3 idlePosition)
		{
		}

		public void ShowAsIdle(float size)
		{
		}
	}
}
