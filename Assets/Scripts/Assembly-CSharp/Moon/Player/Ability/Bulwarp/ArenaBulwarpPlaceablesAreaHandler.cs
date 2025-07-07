using System;
using Chamber8.Framework.Common;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class ArenaBulwarpPlaceablesAreaHandler : SingleMonoBehaviour<ArenaBulwarpPlaceablesAreaHandler, InSceneSingleMonoBehaviourSettings>
	{
		[Serializable]
		private class BoundaryArea
		{
			[SerializeField]
			private string _areaId;

			[SerializeField]
			private ArenaBulwarpBoundaryArea[] _teleportBoundaryAreas;

			public string AreaId => null;

			public ArenaBulwarpBoundaryArea[] TeleportBoundaryAreas => null;

			public void ToggleArea(bool enable)
			{
			}
		}

		[Serializable]
		private class RestrictedArea
		{
			[SerializeField]
			private string _areaId;

			[SerializeField]
			private OverlapShapeDesc _area;

			public string AreaId => null;

			public void ToggleArea(bool enable)
			{
			}
		}

		[SerializeField]
		private BoundaryArea[] _boundaryAreas;

		[SerializeField]
		private RestrictedArea[] _restrictedAreas;

		[SerializeField]
		private bool _allowTeleportOnlyInPlaceableAreas;

		private BoundaryArea ActiveBoundaryArea { get; set; }

		public bool AllowTeleportOnlyInPlaceableAreas => false;

		private void Awake()
		{
		}

		public void SetActiveBoundaryArea(string areaId)
		{
		}

		public void ToggleRestrictedArea(string restrictedAreaId, bool enable)
		{
		}

		public bool IsInTeleportBoundaryArea(Vector3 position, out ArenaBulwarpBoundaryArea area)
		{
			area = null;
			return false;
		}
	}
}
