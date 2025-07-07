using Chamber8.Framework.Common;
using PlayFab;
using UnityEngine.Scripting;

namespace Moon.ReportingSystem
{
	[Preserve]
	public class ReportingService : IInitializer
	{
		private const string ReporteePlayFabIdKey = "ReporteePlayFabId";

		private const string BadBehaviourKey = "BadBehaviour";

		private const string AsModsKey = "AsMods";

		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		public void Initialize()
		{
		}

		public void ReportPlayer(string reporteePlayFabId, BadBehaviour badBehaviour, bool asMods = false)
		{
		}
	}
}
