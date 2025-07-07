using System;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	[OrderAfter(new Type[] { typeof(MNetworkRig) })]
	[NetworkBehaviourWeaved(1)]
	public class MJetstreamWeaponController : MPlayerSuitWeaponController
	{
		[SerializeField]
		private Vector3 _offsetFromHand;

		[SerializeField]
		private Transform _centerPoint;

		private Vector3 _centerPointPosition;

		private Quaternion _centerPointRotation;

		private static Changed<MJetstreamWeaponController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MJetstreamWeaponController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MJetstreamWeaponController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public Transform CenterPoint => null;

		public override void CollectInputData(ref PlayerAbilityWeaponInputData data)
		{
		}

		public override void Render()
		{
		}

		protected override void FollowTransform(Transform trans)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
