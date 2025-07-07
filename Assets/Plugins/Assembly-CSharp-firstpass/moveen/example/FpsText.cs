using System;
using UnityEngine;
using UnityEngine.UI;

namespace moveen.example
{
	public class FpsText : MonoBehaviour
	{
		public float f;

		[NonSerialized]
		private Text text;

		[NonSerialized]
		private float deltaTime;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
