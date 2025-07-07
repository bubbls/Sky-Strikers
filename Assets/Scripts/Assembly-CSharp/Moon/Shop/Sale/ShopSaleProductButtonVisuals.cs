using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Shop.Sale
{
	public class ShopSaleProductButtonVisuals : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CProcessPurchasing_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShopSaleProductButtonVisuals _003C_003E4__this;

			private string[] _003Cdots_003E5__2;

			private float _003Cinterval_003E5__3;

			private int _003Cindex_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CProcessPurchasing_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private Color _defaultColor;

		[SerializeField]
		private Color _confirmColor;

		[SerializeField]
		private Color _purchasedColor;

		[SerializeField]
		private Color _purchasingColor;

		[SerializeField]
		private Image _frameImage;

		[SerializeField]
		private Image _topBottomImage;

		[SerializeField]
		private Color _defaultTopBottomColor;

		[SerializeField]
		private Color _confirmTopBottomColor;

		[SerializeField]
		private Color _purchasingTopBottomColor;

		[SerializeField]
		private Color _purchasedTopBottomColor;

		[SerializeField]
		private GameObject _priceVisualContainer;

		[SerializeField]
		private GameObject _messageVisualContainer;

		[SerializeField]
		private TMP_Text _priceText;

		[SerializeField]
		private TMP_Text _priceBackgroundText;

		[SerializeField]
		private TMP_Text _messageText;

		[SerializeField]
		private TMP_Text _messageBackgroundText;

		[SerializeField]
		private Color32 _purchasingBackgroundMessageColor;

		[SerializeField]
		private Color _purchasedMessageColor;

		[SerializeField]
		private Color _purchasedBackgroundMessageColor;

		[SerializeField]
		private GameObject _purchasedEffectPrefab;

		[SerializeField]
		private Transform _purchasedEffectSpawnPoint;

		[SerializeField]
		private Collider _buttonCollider;

		[SerializeField]
		private Transform _purchasedButtonTargetPoint;

		private Sequence _sequence;

		private bool _isPurchasing;

		private Coroutine _coroutine;

		public void ShowDefaultState(string price)
		{
		}

		public void ShowConfirmState()
		{
		}

		public void ShowPurchasingState()
		{
		}

		public void ShowPurchasedState()
		{
		}

		[IteratorStateMachine(typeof(_003CProcessPurchasing_003Ed__30))]
		private IEnumerator ProcessPurchasing()
		{
			return null;
		}

		private void ShowPurchasedEffect()
		{
		}

		private void UpdateColor(Color frameColor, Color topBottomColor)
		{
		}

		private void UpdateText(string message, Color messageColor, Color messageBackgroundColor)
		{
		}

		private void TogglePriceVisuals(bool enable)
		{
		}

		private void ToggleButtonCollider(bool enable)
		{
		}

		private void StopPurchasingCoroutine()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
