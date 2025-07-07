using System;
using UnityEngine;
using UnityEngine.UI;
using moveen.utils;

namespace moveen.example
{
	public class MoveenPerformanceTest : MonoBehaviour
	{
		public Button btnPlus;

		public Button btnMinus;

		public Button nextModel;

		public Text txtInfo;

		public Transform[] models;

		public int selectedModel;

		public Vector3 pos;

		public int width;

		[NonSerialized]
		private float deltaTime;

		[ReadOnly]
		public int count;

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void increase()
		{
		}

		private void onNextModel()
		{
		}

		private void reset()
		{
		}

		private void decrease()
		{
		}
	}
}
