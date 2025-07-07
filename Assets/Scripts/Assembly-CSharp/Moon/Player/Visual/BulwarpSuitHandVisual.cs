using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class BulwarpSuitHandVisual : PlayerSuitHandVisual
	{
		[SerializeField]
		private Transform _muzzlePoint;

		[SerializeField]
		private BulwarpPaddleVisual _bulwarpPaddleVisual;

		public Transform MuzzlePoint => null;

		public BulwarpPaddleVisual PaddleVisual => null;

		protected override void InitializeInternal()
		{
		}

		public override void SetTeamColor(TeamNo teamNo)
		{
		}
	}
}
