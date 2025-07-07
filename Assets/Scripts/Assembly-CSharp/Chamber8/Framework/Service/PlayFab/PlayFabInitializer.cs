using Chamber8.Framework.Common;
using PlayFab;
using PlayFab.Internal;
using PlayFab.SharedModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class PlayFabInitializer : IInitializer
	{
		public void Initialize()
		{
		}

		private void HandleApiProcessingErrorEvent(PlayFabRequestCommon request, PlayFabError error)
		{
		}

		private void HandleApiProcessingEvent(ApiProcessingEventArgs e)
		{
		}
	}
}
