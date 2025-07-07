using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Service.PlayFab;
using Moon.Leaderboard.Code.Badge;
using Moon.PlayerProfile;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Leaderboard
{
	[Preserve]
	public class PblService : IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PblService _003C_003E4__this;

			private PlayFabAccountService _003CplayFabAccountService_003E5__2;

			private LinkedPlayFabAccount _003ClinkedPlayFabAccount_003E5__3;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private XpRuleConfig? _xpRuleConfig;

		private XpLevelMappingConfig? _xpLevelMappingConfig;

		private LevelBadgeMappingConfig? _levelBadgeMappingConfig;

		public bool IsConfigLoaded => false;

		public event Action? OnConfigLoaded
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

		[AsyncStateMachine(typeof(_003CInitAsync_003Ed__9))]
		private void InitAsync()
		{
		}

		public void GetMyXpAndLevel(Action<int, int> callback)
		{
		}

		public int GetLevelByXp(int xp)
		{
			return 0;
		}

		public int GetXpByLevel(int level)
		{
			return 0;
		}

		public int GetMaxXp()
		{
			return 0;
		}

		public int GetXpGainedFromMatch(PlayerMatchStats matchStats)
		{
			return 0;
		}

		public GameObject? GetBadgePrefabByLevel(int level)
		{
			return null;
		}

		private void GetXpLevelConfig()
		{
		}
	}
}
