using System;
using System.Collections.Generic;
using Chamber8.Framework.Service.Rpc;
using DP.Takeaway.Sound;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Playables;

namespace Moon.Mission
{
	public class TaskCompletion : MonoBehaviour, IRpcServer
	{
		private class RequestPlay
		{
		}

		private const string ServiceName = "Mission_TaskComplition";

		[SerializeField]
		private SoundInfo _sfxBeam;

		[SerializeField]
		private SoundInfo _sfxSkybox;

		[SerializeField]
		private float _sfxSkyBoxDelay;

		private int _sfxIdBeam;

		private int _sfxIdSkybox;

		private Coroutine _sfxSkyBoxRoutine;

		[SerializeField]
		private ParticleSystem _fxClaim;

		[SerializeField]
		private GameObject _taskAccomplishedLight;

		[SerializeField]
		private SoundInfo _sfxTaskAccomplished;

		private int _sfxIdTaskAccomplished;

		[SerializeField]
		private GameObject _spinningSpheres;

		[SerializeField]
		[Header("Activity")]
		private float _activityDelay;

		[SerializeField]
		private GameObject _activityVisualEffect;

		[SerializeField]
		private PlayableDirector _activityPlayableDirector;

		private Coroutine _activityRoutine;

		private IRpcService _rpcService;

		private readonly HashSet<string> _accomplishmentKeys;

		private readonly HashSet<string> _notFinishedKeys;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void Play()
		{
		}

		private void OnSoundCollected(int soundId)
		{
		}

		private void PlayInternal()
		{
		}

		public void OnRequestFromClient(Request request, Action<Response> onComplete)
		{
		}

		public void OnBroadcastFromServer(Request request)
		{
		}

		public void SetHasMissionNotFinished(string key, bool notFinished)
		{
		}

		public void SetMissionAccomplished(string key, bool accomplished)
		{
		}
	}
}
