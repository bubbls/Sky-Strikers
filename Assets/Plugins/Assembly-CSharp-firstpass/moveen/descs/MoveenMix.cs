using System.Collections.Generic;
using UnityEngine;
using moveen.utils;

namespace moveen.descs
{
	public class MoveenMix : OrderedMonoBehaviour
	{
		[Tooltip("Progress from 1-state to 2-state")]
		[Range(0f, 1f)]
		public float progress;

		[Tooltip("Order, at which gometry contains 1-state")]
		public int state1Order;

		[Tooltip("Restore 1-state in Update for the case animation doesn't update some of pos/rot")]
		public bool restore1StateInUpdate;

		public bool skipSelf;

		public List<BeanPosition> bodyParts;

		public Vector3 displaceState1;

		public void Start()
		{
		}

		public override void tick(float dt)
		{
		}

		public override void Update()
		{
		}
	}
}
