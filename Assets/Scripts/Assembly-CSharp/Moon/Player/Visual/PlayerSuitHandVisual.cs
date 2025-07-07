using Moon.AI.VisualScripting;
using Moon.XRSystem;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerSuitHandVisual : PlayerSuitVisualBase
	{
		[SerializeField]
		private PlayerFingerUIInteractor[] _physicalUIInteractors;

		[SerializeField]
		private Transform _palm;

		[SerializeField]
		private PlayerHandPoints _handPoints;

		[SerializeField]
		private OverlapShapeDesc _handOsd;

		[SerializeField]
		private bool _isLeftHandVisual;

		public Transform Palm => null;

		public PlayerHandPoints HandPoints => null;

		public OverlapShapeDesc HandOsd => null;

		protected override void InitializeInternal()
		{
		}

		public void TogglePhysicalUIPointer(bool enable)
		{
		}
	}
}
