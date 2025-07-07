using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fusion;

namespace Moon.Arena
{
	public static class RankedTeamSetUpHelper
	{
		public class MmrPlayer
		{
			public PlayerRef PlayerRef;

			public string PlayFabId;

			public int Mmr;

			public int WinStreak;

			public int HighestWinStreak;

			public int LeaverLevel;
		}

		[CompilerGenerated]
		private sealed class _003CGetCombinations_003Ed__5<T> : IEnumerable<IEnumerable<T>>, IEnumerable, IEnumerator<IEnumerable<T>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private IEnumerable<T> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int length;

			public int _003C_003E3__length;

			private List<T> list;

			public List<T> _003C_003E3__list;

			private int _003Ci_003E5__2;

			private IEnumerator<IEnumerable<T>> _003C_003E7__wrap2;

			IEnumerable<T> IEnumerator<IEnumerable<T>>.Current
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
			public _003CGetCombinations_003Ed__5(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<IEnumerable<T>> IEnumerable<IEnumerable<T>>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static void SetUpTeams(List<string> preservedPlayerIds, Action<MmrPlayer[]> onComplete)
		{
		}

		public static void AssignTeams(List<MmrPlayer> mmrPlayers, int teamSize, out MmrPlayer[] teamOneMmrPlayers, out MmrPlayer[] teamTwoMmrPlayers)
		{
			teamOneMmrPlayers = null;
			teamTwoMmrPlayers = null;
		}

		public static void AssignTeams(List<MmrPlayer> mmrPlayers, int teamSize, out string[] teamOnePlayers, out string[] teamTwoPlayers)
		{
			teamOnePlayers = null;
			teamTwoPlayers = null;
		}

		private static void SetTeamArray(List<MmrPlayer> team, out string[] teamArray, TeamNo teamNo)
		{
			teamArray = null;
		}

		[IteratorStateMachine(typeof(_003CGetCombinations_003Ed__5<>))]
		private static IEnumerable<IEnumerable<T>> GetCombinations<T>(List<T> list, int length)
		{
			return null;
		}
	}
}
