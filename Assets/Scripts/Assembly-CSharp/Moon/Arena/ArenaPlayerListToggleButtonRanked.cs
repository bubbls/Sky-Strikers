using DG.Tweening;
using DP.Takeaway.Sound;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Arena
{
	public class ArenaPlayerListToggleButtonRanked : MonoBehaviour
	{
		[SerializeField]
		private ArenaPlayerListPanelRanked _arenaPlayerListPanel;

		[SerializeField]
		private float _pressingToOpenPlayerListDuration;

		[SerializeField]
		private GameObject _visual;

		[SerializeField]
		private Image _progressImage;

		[SerializeField]
		private Transform _buttonVisualTransform;

		[SerializeField]
		private Transform _idlePositionPoint;

		[SerializeField]
		private Transform _pressedPositionPoint;

		[SerializeField]
		private float _buttonMoveAnimationDuration;

		[SerializeField]
		private SoundPlayerStub _soundPlayerStub;

		private bool _canCheckPressingButtonTimer;

		private float _pressingButtonTimer;

		private bool _isPressingButton;

		private bool _isShowing;

		private Sequence _sequence;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnPlayerLeft()
		{
		}

		private void Update()
		{
		}

		public void HandleOnTriggerEnter()
		{
		}

		public void HandleOnTriggerExit()
		{
		}

		private void KillSequence()
		{
		}
	}
}
