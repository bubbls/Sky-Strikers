using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class PlayerStatsBoardSwitchButton : MonoBehaviour
	{
		private enum BoardType
		{
			Total = 0,
			Class = 1
		}

		[SerializeField]
		private TMP_Text _buttonText;

		[SerializeField]
		private UIButton _uiButton;

		[SerializeField]
		private DOTweenAnimation _doTweenAnimation;

		private BoardType _currentBoardType;

		public event Action OnSwitchButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize()
		{
		}

		public bool IsClassBoard()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnButtonPressed()
		{
		}

		public void UpdateSwitchButton()
		{
		}
	}
}
