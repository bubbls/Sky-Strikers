using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Moon.Shop
{
	public class ShopBalanceRobotText : MonoBehaviour
	{
		[SerializeField]
		private List<TMP_Text> _numbersText;

		[SerializeField]
		private List<TMP_Text> _numbersBackgroundText;

		[SerializeField]
		private Color _textColor;

		[SerializeField]
		private Color _backgroundTextColor;

		[SerializeField]
		private AnimationNumbers _animationNumbers;

		private Tween _numberTextTween;

		private Tween _numberBackgroundTextTween;

		public void Initialize()
		{
		}

		public void UpdateBalance(int currentBalance, int targetBalance)
		{
		}

		public void ShowBalance(int balance)
		{
		}

		private void SetBalanceText(List<string> sortedNumbers, List<TMP_Text> numbersText)
		{
		}

		public void ResetBalanceColor()
		{
		}

		public void ShowErrorBalanceColor()
		{
		}

		private void AnimateNumbersText()
		{
		}

		private void UpdateBalanceColor(Color color, List<TMP_Text> numbersText)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
