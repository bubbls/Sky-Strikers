using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moon.Framework.Base
{
	public class WebRequestManager : MonoBehaviour
	{
		private const int ConcurrentRequestsCount = 6;

		private readonly Dictionary<WebRequestInternal, Coroutine> _pendingRequestsList;

		private readonly List<KeyValuePair<WebRequestInternal, IEnumerator>> _waitingRequestsList;

		private static WebRequestManager _instance;

		public static WebRequestManager Instance => null;

		public void StartRequest(WebRequestInternal request, IEnumerator requestCoroutine)
		{
		}

		public void StopRequest(WebRequestInternal request)
		{
		}

		public void RestartRequest(WebRequestInternal request, IEnumerator requestCoroutine)
		{
		}

		private void TryStartNextPendingRequest()
		{
		}

		private void HandleOnRequestDone(WebRequestInternal request)
		{
		}
	}
}
