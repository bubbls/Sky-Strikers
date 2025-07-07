using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class ArenaBulwarpBoundaryArea : MonoBehaviour
	{
		[SerializeField]
		private OverlapShapeDesc _boundaryQueryArea;

		[SerializeField]
		private Vector2 _minMaxYPlaceablePosition;

		[SerializeField]
		private ArenaBulwarpBoundaryLine _teamOnePlaceableBoundaryLine;

		[SerializeField]
		private ArenaBulwarpBoundaryLine _teamTwoPlaceableBoundaryLine;

		public OverlapShapeDesc BoundaryQueryArea => null;

		public Vector2 MinMaxYPlaceablePosition => default(Vector2);

		public ArenaBulwarpBoundaryLine TeamOnePlaceableBoundaryLine => null;

		public ArenaBulwarpBoundaryLine TeamTwoPlaceableBoundaryLine => null;
	}
}
