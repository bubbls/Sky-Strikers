using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;

namespace Moon.Benchmark
{
	public class RTTOverlay : MonoBehaviour
	{
		[SerializeField]
		private bool _enableMemoryTracking;

		[SerializeField]
		private TMP_Text _textRtt;

		private readonly Cooldown _updateCd;

		private void Start()
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

		private static string GetLatencyColor(int latency)
		{
			return null;
		}
	}
}
