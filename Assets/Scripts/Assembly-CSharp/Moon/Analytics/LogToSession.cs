using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Analytics
{
	public class LogToSession : MonoBehaviour
	{
		[SerializeField]
		private string _statsName;

		public void SetStatsName(string statsName)
		{
		}

		[Preserve]
		public void Log()
		{
		}
	}
}
