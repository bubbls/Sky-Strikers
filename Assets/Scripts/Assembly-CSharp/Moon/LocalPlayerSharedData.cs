using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon
{
	public static class LocalPlayerSharedData
	{
		public static Camera ActiveCamera { get; private set; }

		public static bool HasCamera { get; private set; }

		public static GameCameraType ActiveCameraType { get; private set; }

		public static event Action<Camera, GameCameraType> OnActiveCameraChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void SetActiveCamera(Camera camera, GameCameraType cameraType)
		{
		}
	}
}
