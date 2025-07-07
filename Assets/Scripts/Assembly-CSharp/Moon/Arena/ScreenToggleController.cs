using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Arena
{
	public class ScreenToggleController : MonoBehaviour
	{
		[SerializeField]
		private GameObject _canvas;

		[SerializeField]
		private GameObject _toggleObject;

		[SerializeField]
		private LocalPlayerCheckVolume _checkVolume;

		[SerializeField]
		private Image[] _screenFxImages;

		[SerializeField]
		private float _turnOnScaleSpeed;

		[SerializeField]
		private float _turnOnFadeSpeed;

		[SerializeField]
		private float _turnOffScaleSpeed;

		[SerializeField]
		private float _turnOffFadeSpeed;

		[SerializeField]
		private Transform _flashBg;

		[SerializeField]
		private GameObject[] _standByIcons;

		[SerializeField]
		private bool _showStandbyIcon;

		private Sequence _fxTween;

		public bool IsOn { get; private set; }

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void ToggleFlashBg(bool on)
		{
		}

		private void CheckVolume_OnChanged(bool hasPlayer)
		{
		}

		public void ManualToggle()
		{
		}

		[Button("Turn On", EButtonEnableMode.Always)]
		public void TurnOn()
		{
		}

		[Button("Turn Off", EButtonEnableMode.Always)]
		public void TurnOff()
		{
		}
	}
}
