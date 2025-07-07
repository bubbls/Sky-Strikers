using System;
using System.Collections.Generic;
using Chamber8.Framework.Service.Rpc;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class RPCObjectToggler : MonoBehaviour, IRpcServer
	{
		[Serializable]
		private class RequestToggle
		{
			public string ObjectName;

			public bool Toggle;
		}

		private const string ServiceName = "Tools_RPCObjectToggler";

		private Dictionary<string, GameObject> _toggleHistory;

		[SerializeField]
		private GameObject _targetObject;

		[SerializeField]
		private bool _toggle;

		private IRpcService _rpcService;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		[Button("Send Toggle RPC", EButtonEnableMode.Always)]
		private void NotifyToggle()
		{
		}

		public void OnRequestFromClient(Request request, Action<Response> onComplete)
		{
		}

		public void OnBroadcastFromServer(Request request)
		{
		}

		private void HandleToggle(string objName, bool toggle)
		{
		}

		private static string GetObjScenePath(GameObject obj)
		{
			return null;
		}

		private static GameObject FindGameObjectByScenePath(string scenePath)
		{
			return null;
		}
	}
}
