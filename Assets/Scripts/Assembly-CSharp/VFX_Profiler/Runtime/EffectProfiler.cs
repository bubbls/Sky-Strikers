using System.Collections.Generic;
using UnityEngine;

namespace VFX_Profiler.Runtime
{
	public class EffectProfiler : MonoBehaviour
	{
		[SerializeField]
		private Camera[] _cameras;

		[SerializeField]
		private GameObject _center;

		[HideInInspector]
		public GameObject SingleTarget;

		[SerializeField]
		private EffectProfilerSetting _setting;

		private bool _beginning;

		private bool _profiling;

		private List<string> _assetPath;

		private int _assetIndex;

		private int _cameraIndex;

		private GameObject _target;

		private float _targetDuration;

		private EffectReport _targetReport;

		private bool _singleProfile;
	}
}
