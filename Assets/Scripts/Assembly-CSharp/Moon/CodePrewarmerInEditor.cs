using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class CodePrewarmerInEditor : MonoBehaviour
	{
		private const long Size1Mb = 1048576L;

		private long _lastFrameMemory;

		private long _nextCollectAt;

		[SerializeField]
		private bool _enableManualGC;

		[SerializeField]
		private int _gcHigh;

		[SerializeField]
		private int _gcIncr;

		[SerializeField]
		private int _gcHighEditor;

		[SerializeField]
		private int _gcIncrEditor;

		private bool _wasEnabledManualGC;

		private int GCHigh => 0;

		private int GCIncr => 0;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void FullGC()
		{
		}
	}
}
