using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Moon.Shop.Common;
using TMPro;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class XpBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass31_0
		{
			public XpBar _003C_003E4__this;

			public LevelUpInfo levelUpInfo;

			public LevelUpContext context;

			public Action _003C_003E9__2;

			public Action _003C_003E9__1;

			internal void _003CLevelUpCoroutine_003Eb__1()
			{
			}

			internal void _003CLevelUpCoroutine_003Eb__2()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAnimateXpBarCoroutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XpBar _003C_003E4__this;

			public float from;

			public float to;

			public float duration;

			public Action callback;

			private float _003Ctime_003E5__2;

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
			public _003CAnimateXpBarCoroutine_003Ed__34(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CLevelUpCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XpBar _003C_003E4__this;

			public LevelUpInfo levelUpInfo;

			private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

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
			public _003CLevelUpCoroutine_003Ed__31(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTestLvUp_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XpBar _003C_003E4__this;

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
			public _003CTestLvUp_003Ed__25(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CUpdateChargeBadgeProgress_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XpBar _003C_003E4__this;

			public LevelUpContext context;

			public Action chargeBadgeFinishedCallback;

			private float _003CelapsedTime_003E5__2;

			private float _003ClevelUpDuration_003E5__3;

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
			public _003CUpdateChargeBadgeProgress_003Ed__37(int _003C_003E1__state)
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
		private TMP_Text _levelText;

		[SerializeField]
		private GameObject _defaultBadge;

		[SerializeField]
		private VRPhysicsButtonInteraction _vrPhysicsButtonInteraction;

		[SerializeField]
		private LevelUpEffects _levelUpEffects;

		[SerializeField]
		private PlayerStatsFrame _playerStatsFrame;

		[SerializeField]
		private GameObject _badgeContainer;

		[SerializeField]
		private GameObject _currentBadge;

		[SerializeField]
		private MeshRenderer _renderer;

		[SerializeField]
		private float _topUpMin;

		[SerializeField]
		private float _topUpMax;

		[SerializeField]
		private float _chargeBadgeMin;

		[SerializeField]
		private float _chargeBadgeMax;

		[SerializeField]
		private float _chargeBadgeShorterDuration;

		[SerializeField]
		private float _chargeBadgeNormalDuration;

		[SerializeField]
		private float _chargeBadgeAnimSpeedFastVersion;

		[SerializeField]
		private float _chargeBadgeAnimSpeedNormalVersion;

		private PblService _pblService;

		private PlayerStatistics _statistics;

		private bool _hasMovedDown;

		private bool _isLevelUpInProgress;

		private bool _isSingleLevelUpInProgress;

		private static readonly int _xpTopUp;

		private static readonly int _xpChargeBadge;

		public void Initialize()
		{
		}

		public void SetNotAvailable()
		{
		}

		[IteratorStateMachine(typeof(_003CTestLvUp_003Ed__25))]
		public IEnumerator TestLvUp()
		{
			return null;
		}

		private void StartLevelUp(LevelUpInfo levelUpInfo)
		{
		}

		private void OnPlayerHandEnterBadge(bool obj)
		{
		}

		private void OnConfigLoaded()
		{
		}

		public void UpdateStats(PlayerStatistics statistics, LevelUpInfo levelUpInfo)
		{
		}

		private void MoveDownBadge()
		{
		}

		[IteratorStateMachine(typeof(_003CLevelUpCoroutine_003Ed__31))]
		private IEnumerator LevelUpCoroutine(LevelUpInfo levelUpInfo)
		{
			return null;
		}

		private void LevelUpFinished()
		{
		}

		private float GetProgress()
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CAnimateXpBarCoroutine_003Ed__34))]
		private IEnumerator AnimateXpBarCoroutine(float from, float to, float duration, Action callback = null)
		{
			return null;
		}

		private void EquipBadge(int level)
		{
		}

		private void UpdateTopUpProgress(float value)
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateChargeBadgeProgress_003Ed__37))]
		private IEnumerator UpdateChargeBadgeProgress(LevelUpContext context, Action chargeBadgeFinishedCallback)
		{
			return null;
		}

		private void ResetProgress()
		{
		}

		private float GetLevelUpDuration(LevelUpContext context)
		{
			return 0f;
		}

		private float GetLevelUpAnimSpeed(LevelUpContext context)
		{
			return 0f;
		}
	}
}
