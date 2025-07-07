using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Moon.Framework.Leaderboard;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.InGameActivity
{
	public class InGameActivityVisualManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountdownCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InGameActivityVisualManager _003C_003E4__this;

			public double remainingTime;

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
			public _003CCountdownCoroutine_003Ed__16(int _003C_003E1__state)
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
		private List<InGameActivityPlayerEntry> _topPlayerEntries;

		[SerializeField]
		private InGameActivityPlayerEntry _playerEntry;

		[SerializeField]
		private TMP_Text _countDownText;

		[SerializeField]
		private Image _progressFillImage;

		[SerializeField]
		private TMP_Text _progressText;

		[SerializeField]
		private List<GameObject> _activityVisuals;

		[SerializeField]
		private TMP_Text _timerText;

		private const string ActivityExpiredText = "Event Ended";

		private Coroutine _countDownCoroutine;

		private InGameActivityRemoteConfig _activityRemote;

		public void Initialize()
		{
		}

		public void UpdateTimer(int remainingTime)
		{
		}

		public void UpdatePlayersData(IReadOnlyList<LeaderboardEntry> top10Players, LeaderboardEntry localPlayerLeaderboardEntry, int totalPoints)
		{
		}

		public void UpdateVisuals(InGameActivityInfoResponseData responseData, bool isActivityCompleted)
		{
		}

		public void ToggleActivityVisuals(bool enable)
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CCountdownCoroutine_003Ed__16))]
		private IEnumerator CountdownCoroutine(double remainingTime)
		{
			return null;
		}

		private string ConvertSecondsToReadableTime(double seconds)
		{
			return null;
		}

		private void StopCountdownCoroutine()
		{
		}
	}
}
