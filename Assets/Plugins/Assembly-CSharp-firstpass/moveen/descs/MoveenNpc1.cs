using System;
using UnityEngine;
using moveen.example;
using moveen.utils;

namespace moveen.descs
{
	public class MoveenNpc1 : MonoBehaviour
	{
		private MoveControl3 mc3;

		[NonSerialized]
		private CharInfo ci;

		[ReadOnly]
		public float thinkPause;

		[ReadOnly]
		public float idlePause;

		[ReadOnly]
		public float lookPause;

		public P<Vector3> placeToGo;

		[NonSerialized]
		private Vector3 lookPos;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void chooseAction()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
