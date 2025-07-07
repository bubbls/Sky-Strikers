using DG.Tweening;
using Moon.Arena;
using UnityEngine;

namespace Moon.Shop.Sale
{
	public class ShopModelSwitcher : MonoBehaviour
	{
		[SerializeField]
		private Transform _spawnModelTeamOnePoint;

		[SerializeField]
		private Transform _spawnModelTeamTwoPoint;

		[SerializeField]
		private ShopSaleProductVisuals? _visualsTeamOne;

		[SerializeField]
		private ShopSaleProductVisuals? _visualsTeamTwo;

		[SerializeField]
		private float _switchDuration;

		[SerializeField]
		private float _meltingDuration;

		private Sequence? _sequence;

		public void Start()
		{
		}

		public void Play(TeamNo targetTeam)
		{
		}

		public void SetPurchaseSucceedState()
		{
		}

		public void Play()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
