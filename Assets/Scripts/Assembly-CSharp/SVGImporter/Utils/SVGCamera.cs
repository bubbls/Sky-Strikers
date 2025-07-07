using System;
using UnityEngine;

namespace SVGImporter.Utils
{
	[RequireComponent(typeof(Camera))]
	public class SVGCamera : MonoBehaviour
	{
		public static Action<Camera> onPreRender;

		protected Camera _camera;

		public Camera camera => null;

		private void OnPreRender()
		{
		}

		public static void UpdateCameras()
		{
		}
	}
}
