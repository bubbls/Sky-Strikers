using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using Chamber8.Framework.Core;
using Moon.Framework.RemoteConfig;
using PlayFab;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class ServerRemoteConfigService : IRemoteConfig, IInitializer, IConditionalCreation
	{
		private PlayFabServerInstanceAPI _serverInstanceAPI;

		public void Initialize()
		{
		}

		public void Get(string key, Action<string>? onSuccess, Action<PlayFabError>? onError)
		{
		}

		public void Get(List<string> keys, Action<Dictionary<string, string>>? onSuccess, Action<PlayFabError>? onError)
		{
		}

		public bool CreateOnCondition()
		{
			return false;
		}
	}
}
