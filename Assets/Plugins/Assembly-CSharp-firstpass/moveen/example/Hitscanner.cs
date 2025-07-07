using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using moveen.utils;

namespace moveen.example
{
	public class Hitscanner : OrderedMonoBehaviour
	{
		[NonSerialized]
		public bool hitFound;

		[NonSerialized]
		public RaycastHit raycastHit;

		[NonSerialized]
		public Vector3 origin;

		public Vector3 direction;

		[FormerlySerializedAs("target")]
		[Tooltip("GameObject which is represents aim. Its location will be set to be at aimed GameObject. You can put some effects into the \"aim\" to play them when the gun is fired.")]
		public Transform aim;

		[Tooltip("The layer which will be used to detect surface. For example, create a layer for objects you want to walk on and name it as \"ground\" or \"terrain\"")]
		public LayerMask layer;

		[Tooltip("Don't consider back surface")]
		public bool ignoreBackSurface;

		[Tooltip("How far detector should look")]
		public float maxDetectDistance;

		[Tooltip("Maximum number of crosses detected. Consider simplification of your scene instead of increasing of this number")]
		public int bufferSize;

		[NonSerialized]
		private RaycastHit[] buffer;

		[NonSerialized]
		public bool resetMaxFoundHits;

		[NonSerialized]
		public int maxFoundHits;

		public Transform hierarchyToIgnore;

		[NonSerialized]
		public List<Collider> collidersToIgnore;

		public override void OnEnable()
		{
		}

		public virtual Ray getRay()
		{
			return default(Ray);
		}

		public override void tick(float dt)
		{
		}

		public void addCollisionHierarchyToIgnore(Transform go)
		{
		}
	}
}
