using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Hub
{
	public class AdditionalSceneHandler : AdditiveSceneHandler
	{
		[ScenePath]
		[SerializeField]
		private string _scenePath;

		[SerializeField]
		private Transform _placePosition;

		[SerializeField]
		private bool _hideAfterMoved;

		public Transform PlacePosition => null;

		private void Awake()
		{
		}

		protected override void OnAdditiveSceneLoaded()
		{
		}
	}
}
