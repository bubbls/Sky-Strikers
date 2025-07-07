using System;
using Fusion;
using UnityEngine;

[NetworkBehaviourWeaved(24)]
[OrderBefore(new Type[] { typeof(NetworkTransform) })]
[RequireComponent(typeof(CharacterController))]
[DisallowMultipleComponent]
public class NetworkCharacterControllerPrototype : NetworkTransform
{
	[Header("Character Controller Settings")]
	public float gravity;

	public float jumpImpulse;

	public float acceleration;

	public float braking;

	public float maxSpeed;

	public float rotationSpeed;

	[SerializeField]
	[HideInInspector]
	[DefaultForProperty("IsGrounded", 20, 1)]
	private bool _IsGrounded;

	[HideInInspector]
	[SerializeField]
	[DefaultForProperty("Velocity", 21, 3)]
	private Vector3 _Velocity;

	private static Changed<NetworkCharacterControllerPrototype> _0024IL2CPP_CHANGED;

	private static ChangedDelegate<NetworkCharacterControllerPrototype> _0024IL2CPP_CHANGED_DELEGATE;

	private static NetworkBehaviourCallbacks<NetworkCharacterControllerPrototype> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[NetworkedWeaved(20, 1)]
	[Networked]
	[HideInInspector]
	public bool IsGrounded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[HideInInspector]
	[Networked]
	[NetworkedWeaved(21, 3)]
	public Vector3 Velocity
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	protected override Vector3 DefaultTeleportInterpolationVelocity => default(Vector3);

	protected override Vector3 DefaultTeleportInterpolationAngularVelocity => default(Vector3);

	public CharacterController Controller { get; private set; }

	protected override void Awake()
	{
	}

	public override void Spawned()
	{
	}

	private void CacheController()
	{
	}

	protected override void CopyFromBufferToEngine()
	{
	}

	public virtual void Jump(bool ignoreGrounded = false, float? overrideImpulse = null)
	{
	}

	public virtual void Move(Vector3 direction)
	{
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	public override void CopyStateToBackingFields()
	{
	}
}
