using System;
using UnityEngine;

namespace moveen.example
{
	public class SimpleRotate : MonoBehaviour
	{
		public float angleStep;

		[NonSerialized]
		private Quaternion initialRot;

		[NonSerialized]
		private float angle;

		private void OnEnable()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
