using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class ArenaBulwarpBoundaryQueryBox : MonoBehaviour
	{
		[SerializeField]
		private OverlapShapeDesc _queryBox;

		[SerializeField]
		private Vector2 _minMaxYPlaceablePosition;

		public OverlapShapeDesc QueryBox => null;

		public Vector2 MinMaxYPlaceablePosition => default(Vector2);
	}
}
