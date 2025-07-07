using System;
using System.Net;
using Chamber8.Framework.Common;
using PlayFab;
using UnityEngine.Scripting;

namespace Moon.Bootstrap
{
	[Preserve]
	public class ServerSessionService : IInitializer
	{
		private PlayFabCloudScriptInstanceAPI _cloudScriptServerInstanceAPI;

		private PlayFabCloudScriptInstanceAPI _cloudScriptPlayerInstanceAPI;

		private const string ServerId = "ServerId";

		private const string SessionId = "SessionId";

		private const string ServerCode = "Code";

		private const string PhotonRegion = "PhotonRegion";

		private const string PlayFabRegion = "PlayFabRegion";

		private const string FieldType = "FieldType";

		private const string SocialPrivacyState = "SocialPrivacyState";

		public void Initialize()
		{
		}

		public void RegisterServer(ServerRegistrationRequest registrationRequest, Action<string> onSuccess, Action<HttpStatusCode, string> onError)
		{
		}

		public void UpdateServerHeartbeat(string fieldType, string serverCode, string sessionId, string photonRegion, string playfabRegion)
		{
		}

		public void GetServerSessionInfoFromSessionId(string fieldType, string sessionId, Action<ServerSessionInfo> onSuccess, Action onFailed)
		{
		}

		public void GetServerSessionInfoFromServerCode(string fieldType, string serverCode, Action<ServerSessionInfo> onSuccess, Action onFailed)
		{
		}

		private void GetServerSessionInfo(string funcName, string fieldType, string idParamName, string idParamValue, Action<ServerSessionInfo> onSuccess, Action onFailed)
		{
		}

		public void GetRequestedServerSessionInfo(string serverId, Action<ServerSessionInfo> onSuccess, Action<HttpStatusCode> onFailed)
		{
		}

		public void RecordPlayerConnectionToServer(string sessionId, string playfabRegion, string fieldType)
		{
		}

		public void RequestServer(string fieldType, string playFabRegion, Action<string> onSuccess, Action<RequestServerResultError> onFailed)
		{
		}

		public void NotifyManualServerRequestComplete(string serverId, string fieldType, string code)
		{
		}
	}
}
