using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerCustomizationNavigationPanel : MonoBehaviour
	{
		[SerializeField]
		private UIButton _backButton;

		[SerializeField]
		private UIButton _forwardButton;

		[SerializeField]
		private TMP_Text _pageNumText;

		private int _maxPages;

		public int CurrentSimulatedPageIndex { get; private set; }

		public event Action OnBackButtonPressed
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

		public event Action OnPageChanged
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

		public event Action OnForwardButtonPressed
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

		public void SetPage(int pageIndex, int maxPages)
		{
		}

		private void ForwardButton_OnButtonPressed()
		{
		}

		private void BackButton_OnButtonPressed()
		{
		}
	}
}
