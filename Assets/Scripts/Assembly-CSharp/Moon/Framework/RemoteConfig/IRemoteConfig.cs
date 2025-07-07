using System;
using System.Collections.Generic;
using PlayFab;

namespace Moon.Framework.RemoteConfig
{
	public interface IRemoteConfig
	{
		void Get(string key, Action<string>? onSuccess, Action<PlayFabError>? onError);

		void Get(List<string> keys, Action<Dictionary<string, string>>? onSuccess, Action<PlayFabError>? onError);
	}
}
