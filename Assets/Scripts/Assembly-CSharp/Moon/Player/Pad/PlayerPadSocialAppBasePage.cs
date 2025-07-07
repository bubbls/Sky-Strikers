using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppBasePage : MonoBehaviour
	{
		[SerializeField]
		protected PlayerPadSocialAppTabButton _tabButton;

		[SerializeField]
		protected ScrollRect _scrollRect;

		[SerializeField]
		private GameObject _container;

		[SerializeField]
		protected GameObject _entryPrefab;

		[SerializeField]
		protected Transform _entryContainer;

		[SerializeField]
		protected int _defaultEntriesCount;

		protected SocialService _socialService;

		public ScrollRect ScrollRect => null;

		public event Action OnShowPage
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

		public void Initialize(SocialService socialService)
		{
		}

		public virtual void UpdateTabButtonText()
		{
		}

		public virtual void SetDefaultState()
		{
		}

		protected virtual void InitializeInternal()
		{
		}

		public void ToggleTabButton(bool enable)
		{
		}

		public void ToggleTabButtonInteraction(bool enable)
		{
		}

		public void ToggleUI(bool enable)
		{
		}

		protected virtual void HandleOnPageShow()
		{
		}

		protected virtual void HandleOnPageHide()
		{
		}

		private void OnEnable()
		{
		}

		protected virtual void HandleOnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void HandleOnDisable()
		{
		}

		private void HandleOnTabButtonPressed()
		{
		}
	}
}
