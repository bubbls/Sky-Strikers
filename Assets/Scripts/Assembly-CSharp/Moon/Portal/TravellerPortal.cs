using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon.Portal
{
	public class TravellerPortal : InPlaceList<TravellerPortal>
	{
		public enum CrossDirection
		{
			NegativeToPositive = 0,
			PositiveToNegative = 1,
			Both = 2
		}

		[SerializeField]
		private bool _isStatic;

		[SerializeField]
		private CrossDirection _allowedCrossDirection;

		[SerializeField]
		private TravellerPortal _linkedPortal;

		[SerializeField]
		protected Transform _teleportInTransform;

		[SerializeField]
		protected Transform _teleportOutTransform;

		private Matrix4x4? _cachedRelativeMatrix;

		private Matrix4x4? _cachedTeleportMatrix;

		public bool IsStatic => false;

		public CrossDirection AllowedCrossDirection => default(CrossDirection);

		public TravellerPortal LinkedPortal => null;

		public Transform TeleportInTransform => null;

		public Transform TeleportOutTransform => null;

		public event Action<TravellerPortal, PortalTraveller> OnTravellerEnter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<TravellerPortal, PortalTraveller> OnTravellerExit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public void NotifyTravellerCrossed(PortalTraveller traveller, float side)
		{
		}

		public Matrix4x4 GetTeleportMatrix(Transform t)
		{
			return default(Matrix4x4);
		}

		private Matrix4x4 GetTeleportMatrix()
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetRelativeMatrix(Transform t)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetRelativeMatrix()
		{
			return default(Matrix4x4);
		}
	}
}
