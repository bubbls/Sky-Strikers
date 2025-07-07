using System;
using UnityEngine;

namespace moveen.example
{
	public class HitscannerMouse : Hitscanner
	{
		public FocusGrabber focusGrabber;

		public Camera cam;

		[NonSerialized]
		public Ray lastRay;

		public override void OnEnable()
		{
		}

		public override Ray getRay()
		{
			return default(Ray);
		}
	}
}
