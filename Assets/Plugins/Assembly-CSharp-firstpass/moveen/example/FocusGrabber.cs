using System;
using UnityEngine;

namespace moveen.example
{
	public class FocusGrabber : MonoBehaviour
	{
		public static FocusGrabber CURRENT_GRABBER;

		public bool grab;

		[NonSerialized]
		private bool wasGrabbing;

		private void Update()
		{
		}
	}
}
