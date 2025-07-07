using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		private static int instancesInScene;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredFloat. Increase in case of false positives.")]
		public float floatEpsilon;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector2. Increase in case of false positives.")]
		public float vector2Epsilon;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector3. Increase in case of false positives.")]
		public float vector3Epsilon;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredQuaternion. Increase in case of false positives.")]
		public float quaternionEpsilon;

		public static ObscuredCheatingDetector Instance { get; private set; }

		private static ObscuredCheatingDetector GetOrCreateInstance => null;

		internal static bool IsRunning => false;

		public static void StartDetection()
		{
		}

		public static void StartDetection(UnityAction callback)
		{
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private ObscuredCheatingDetector()
		{
		}

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnLevelLoadedCallback()
		{
		}

		private void StartDetectionInternal(UnityAction callback)
		{
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override void PauseDetector()
		{
		}

		protected override void ResumeDetector()
		{
		}

		protected override void StopDetectionInternal()
		{
		}

		protected override void DisposeInternal()
		{
		}
	}
}
