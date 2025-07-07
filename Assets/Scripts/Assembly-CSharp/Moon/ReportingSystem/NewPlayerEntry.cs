using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Moon.Arena;
using Moon.Hub;
using TMPro;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class NewPlayerEntry : NewPlayerEntryBase
	{
		[CompilerGenerated]
		private sealed class _003CTunePlayerNoRoutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewPlayerEntry _003C_003E4__this;

			public bool isUp;

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
			public _003CTunePlayerNoRoutine_003Ed__36(int _003C_003E1__state)
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

		private const float InitialPlayerNoTuneCd = 1f;

		private const string VisualKeyOnLevel1 = "on_level_1";

		private const string VisualKeyOnLevel2 = "on_level_2";

		private const string VisualKeyOnLevel3 = "on_level_3";

		private const string VisualKeyOn = "on";

		private const string VisualKeyOff = "off";

		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private TMP_Text _textRtt;

		[SerializeField]
		private TMP_Text _textPlayerName;

		[SerializeField]
		private TMP_Text _textPlayerNo;

		[SerializeField]
		private PushLockButton _btnNumUp;

		[SerializeField]
		private PushLockButton _btnNumDown;

		[SerializeField]
		private SoundInfo _sfxTunePlayerNo;

		[SerializeField]
		private ManualButton _btnTeam;

		private KeyIndexedVisual[] _teamIcons;

		[SerializeField]
		private ManualButton _btnMyVoice;

		private KeyIndexedVisual _myVoiceIcon;

		[SerializeField]
		private ManualButton _btnOthersVoice;

		private KeyIndexedVisual _othersVoiceIcon;

		[SerializeField]
		private ManualButton _btnKickPlayer;

		[SerializeField]
		private ManualButton _btnReport;

		[SerializeField]
		private ReportContextMenu _reportContextMenu;

		[SerializeField]
		private SpeakerVisualizer _speakerVisualizer;

		private readonly Cooldown _tunePlayerNoCd;

		private int _cachedPlayerNo;

		private Coroutine _tuneNumberRoutine;

		protected override void InitializeInternal()
		{
		}

		private void OnEnable()
		{
		}

		private void HandleKickPlayer()
		{
		}

		private void HandleRequestReport(BadBehaviour badBehaviour)
		{
		}

		private void HandleReportButtonPressed()
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		private void HandleNumUpTriggering()
		{
		}

		private void HandleNumDownTriggering()
		{
		}

		private void StopTuningCoroutineAndResetCd(bool resetToInitial = false)
		{
		}

		private void HandleReleaseNumButton()
		{
		}

		[IteratorStateMachine(typeof(_003CTunePlayerNoRoutine_003Ed__36))]
		private IEnumerator TunePlayerNoRoutine(bool isUp)
		{
			return null;
		}

		private void TunePlayerNo(bool isUp)
		{
		}

		private Color GetPlayerNameColor(TeamNo teamNo)
		{
			return default(Color);
		}

		protected override void UpdatePlayerInfoInternal()
		{
		}

		public override void UpdateRtt(int rtt)
		{
		}

		private void UpdateSpeakerStatus()
		{
		}

		public override void ToggleReportContextMenu(bool show)
		{
		}

		private void HandleMyVoiceButtonPressed()
		{
		}

		private void HandleOthersVoiceButtonPressed()
		{
		}

		private void HandleTeamButtonPressed()
		{
		}

		protected override void SetMicEnabledInternal(bool micEnabled)
		{
		}

		protected override void SetSpeakerVolumeInternal(MPlayer.PlayerSpeakerVolume volume)
		{
		}
	}
}
