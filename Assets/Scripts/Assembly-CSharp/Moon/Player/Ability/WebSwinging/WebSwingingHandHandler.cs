using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Player.Ability.WebSwinging
{
	public class WebSwingingHandHandler
	{
		private bool _hasWeb;

		private bool _isShootingWeb;

		private bool _hasWebAttachPoint;

		private Transform _webParent;

		private LineRenderer _webLine;

		private Vector3 _targetWebAttachPos;

		private Vector3 _currentWebPointOnePos;

		private Vector3 _currentControllerPosition;

		private Vector3 _lastControllerPosition;

		private Vector3 _webDirectionFromHand;

		private Vector3 _controllerVelocity;

		private float _currentWebLength;

		private readonly GameObject _targetingIndicator;

		private readonly LocalPlayerRig _localPlayerRig;

		private readonly MPlayerAbilityWebSwinging.WebShootingConfig _config;

		private readonly bool _isLeft;

		private SpringJoint _joint;

		private Ray _cachedRay;

		private RaycastHit _cachedRayHit;

		private Vector3 _lastPlayerPosition;

		private Vector3 _currentPlayerPosition;

		private int _velocitySamplesCount;

		private Vector3[] _velocitySamples;

		private int _sampleIndex;

		public bool IsSwinging { get; private set; }

		public event Action OnWebAttachedToSurface
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

		public event Action OnWebReleased
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

		public WebSwingingHandHandler(ref LocalPlayerRig localPlayerRig, ref MPlayerAbilityWebSwinging.WebShootingConfig config, GameObject targetingIndicator, MPlayerHand hand)
		{
		}

		public void ExecuteFixed()
		{
		}

		public void ExecuteLate()
		{
		}

		public void HandleOnTriggerPressed(MPlayerHand hand, Vector3 controllerPosition)
		{
		}

		public void HandleOnTriggerHold(MPlayerHand hand, Vector3 controllerPosition)
		{
		}

		public void HandleOnTriggerReleased(MPlayerHand hand, Vector3 controllerPosition)
		{
		}

		private void DetectPull()
		{
		}

		public void Reset()
		{
		}

		private void CalculateVelocity()
		{
		}

		private Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		private void ClearSamples()
		{
		}
	}
}
