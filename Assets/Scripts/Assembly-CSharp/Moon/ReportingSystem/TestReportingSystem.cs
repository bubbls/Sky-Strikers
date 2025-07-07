using NaughtyAttributes;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class TestReportingSystem : MonoBehaviour
	{
		private const string TestReporteePlayFabId = "83BE2E246E92DAD";

		[Button(null, EButtonEnableMode.Always)]
		private void ReportAPlayer()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void PutPlayerInJail()
		{
		}
	}
}
