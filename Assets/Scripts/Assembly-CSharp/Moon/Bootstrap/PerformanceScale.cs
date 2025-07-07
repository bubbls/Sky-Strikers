using Chamber8.Framework.Common;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon.Bootstrap
{
	public class PerformanceScale : MonoBehaviour
	{
		public const float TargetRefreshRate = 90f;

		private const int TargetTickRate = 90;

		private const int TunedPhysicsFixedDeltaTimeMultiplier = 8;

		private const float EyeTextureResolutionScaleMobile = 0.94f;

		private const float EyeTextureResolutionScaleDefault = 1f;

		public static bool EnablePostProcess;

		public static bool EnableAnalysis;

		private static float _totalTime;

		private static float _curTargetFps;

		private static float _fpsTime;

		private static float _fpsValue;

		private static int _fpsCount;

		private static float _cachedTunedPhysicsDeltaTime;

		private static float _cachedCurrentFixedDeltaTime;

		private static float _cachedScaledDeltaTime;

		private static int _curTargetFixedDeltaTimeMultiplier;

		private static readonly RingBuffer<float> _jankBuffer;

		private static float _jankTime;

		private static int _jankCount;

		private static RingBuffer<float> _deltaBuffer;

		private static readonly int _maxBufferNum;

		private static int _curCalculateCount;

		private static float _totalStandardDeviation;

		[SerializeField]
		private InputActionReference _exportProfilerLogInput;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		private void RegisterDebugAction(bool enable)
		{
		}

		private void OnDisable()
		{
		}

		private void HandleInputActionToggle(InputAction.CallbackContext context)
		{
		}

		private static void PrintPipelineAssetInfo()
		{
		}

		private static void HandleConnSceneLoaded()
		{
		}

		public static void ScalePhysicsForceVector(ref Vector3 vector, ForceMode forceMode)
		{
		}

		public static void RefreshFixedDeltaTime(float? refreshRate = null)
		{
		}

		private static void UpdatePerformanceScaleSettings()
		{
		}

		private static void UpdateFrameRate()
		{
		}

		public static void SetRefreshRate(float? refreshRate = null)
		{
		}

		public static float GetRefreshRate()
		{
			return 0f;
		}

		public static void SetRenderScale(float renderScale)
		{
		}

		public static float GetRenderScale()
		{
			return 0f;
		}

		public static float GetCurrentFPS()
		{
			return 0f;
		}

		public static int GetCurrentJankCount()
		{
			return 0;
		}

		public static float GetCurrentStutter()
		{
			return 0f;
		}

		public static float GetCurrentStandardDeviation()
		{
			return 0f;
		}

		public static void Reset()
		{
		}

		private void UpdateEffectSettings()
		{
		}

		private static float StandardDeviation(RingBuffer<float> buffer)
		{
			return 0f;
		}
	}
}
