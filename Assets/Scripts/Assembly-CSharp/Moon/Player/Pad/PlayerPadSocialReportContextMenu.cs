using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Runtime;
using Moon.ReportingSystem;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialReportContextMenu : ReportContextMenuBase
	{
		[Serializable]
		private class ButtonsLookup : SerializableDictionary<BadBehaviour, UIButton>
		{
		}

		[SerializeField]
		private GameObject _uiContainer;

		[SerializeField]
		private GameObject _background;

		[SerializeField]
		private ButtonsLookup _buttonsLookup;

		[SerializeField]
		private UIExpandableMenu _expandableMenu;

		[SerializeField]
		private GameObject _reportSentVisual;

		[SerializeField]
		private float _showReportedDelay;

		private bool _isShowing;

		private BadBehaviour _lastReportedBehaviour;

		private int _timerId;

		public override bool IsShowing => false;

		public event Action OnReportContextMenuClosedAfterReport
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

		private void OnDestroy()
		{
		}

		private void HandleReportButtonPressed(BadBehaviour badBehaviour)
		{
		}

		public override void ResetToInitialStatus()
		{
		}

		public override void Toggle(bool show, Action callback = null)
		{
		}

		private void CollapseMenu(Action callback)
		{
		}

		private void SetReportButtonsStatus()
		{
		}

		private void DoReport(BadBehaviour badBehaviour)
		{
		}

		private void ToggleButtonLayerIfShowing(bool allowInteraction)
		{
		}

		private void ToggleUIContainer(bool show)
		{
		}

		private void ToggleReportSentVisual(bool show)
		{
		}
	}
}
