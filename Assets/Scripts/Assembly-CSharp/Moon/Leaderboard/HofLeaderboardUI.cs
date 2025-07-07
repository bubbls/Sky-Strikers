using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Moon.Framework.Leaderboard;
using TMPro;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class HofLeaderboardUI : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public HofLeaderboardUI _003C_003E4__this;

			public int leaderBoardTopN;

			private int _003Coffset_003E5__2;

			private int _003Ci_003E5__3;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		[SerializeField]
		private HofLeaderboardUIEntry? _firstLeaderboardEntry;

		[SerializeField]
		private HofLeaderboardUIEntry? _myLeaderboardEntry;

		[SerializeField]
		private HofLeaderboardUIEntryConfig _defaultConfig;

		[SerializeField]
		private List<HofLeaderboardUIEntryConfig> _configs;

		[SerializeField]
		private TMP_Text? _textLeaderboardName;

		[SerializeField]
		private HofLeaderboardUIEntry _uiEntryPrefab;

		[SerializeField]
		private Transform? _root;

		private List<HofLeaderboardUIEntry> _entriesUI;

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__8))]
		public Task InitializeAsync(int leaderBoardTopN)
		{
			return null;
		}

		public void SetDisplayName(string displayName)
		{
		}

		public void SetEntries(int topN, List<LeaderboardEntry> entries, LeaderboardEntry? myEntry)
		{
		}

		private void RemoveAllElements()
		{
		}

		private HofLeaderboardUIEntryConfig GetConfig(int i)
		{
			return default(HofLeaderboardUIEntryConfig);
		}

		public void Clear()
		{
		}
	}
}
