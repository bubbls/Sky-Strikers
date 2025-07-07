using UnityEngine;
using UnityEngine.Events;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu(null)]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		protected static GameObject detectorsContainer;

		[Tooltip("Automatically start detector. Detection Event will be called on detection.")]
		public bool autoStart;

		[Tooltip("Detector will survive new level (scene) load if checked.")]
		public bool keepAlive;

		[Tooltip("Automatically dispose Detector after firing callback.")]
		public bool autoDispose;

		[SerializeField]
		protected UnityEvent detectionEvent;

		protected UnityAction detectionAction;

		[SerializeField]
		protected bool detectionEventHasListener;

		protected bool isRunning;

		protected bool started;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationQuit()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return false;
		}

		protected virtual void DisposeInternal()
		{
		}

		protected virtual bool DetectorHasAdditionalCallbacks()
		{
			return false;
		}

		internal virtual void OnCheatingDetected()
		{
		}

		protected abstract void StartDetectionAutomatically();

		protected abstract void StopDetectionInternal();

		protected abstract void PauseDetector();

		protected abstract void ResumeDetector();
	}
}
