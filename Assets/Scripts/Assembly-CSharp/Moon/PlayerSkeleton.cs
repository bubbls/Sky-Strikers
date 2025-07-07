using System;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public struct PlayerSkeleton
	{
		public Transform Head;

		public Transform Body;

		public Transform Leg;

		public Transform Suit;

		public Transform LeftHand;

		public Transform LeftHandIkConnectionPoint;

		public Transform RightHand;

		public Transform RightHandIkConnectionPoint;

		public Transform UnequippedWeaponPoint;

		public Transform LeftHandWeaponPoint;

		public Transform RightHandWeaponPoint;

		public Transform Backpack;

		public Transform BackpackWaistGrabVisualPoint;

		public Transform NameTag;
	}
}
