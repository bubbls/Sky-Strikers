using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;

namespace Moon.Mission
{
	public class MissionManager : Singleton<MissionManager>
	{
		[Serializable]
		private class Record
		{
			public string BundleId;

			public int Duration;
		}

		[Serializable]
		private class RecordList
		{
			public List<Record> Records;
		}

		private class InProgressMissions
		{
			public string DueTime;

			public List<string> Missions;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestMissions_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MissionManager _003C_003E4__this;

			public MissionTable missionTable;

			private TaskAwaiter<MissionRecordList> _003C_003Eu__1;

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

		private const string MissionRecordKey = "missionRecord";

		private readonly Dictionary<MissionTable, MissionRecordList> _missionDataDict;

		private readonly Dictionary<MissionTable, bool> _requesting;

		private MissionService _missionService;

		private bool _isInitialized;

		private HashSet<string> _inProgressMissions;

		private IMessageSubscriber _subscriber;

		private const string InProgressMissionsKey = "InProgressMissions";

		public event Action<MissionTable> OnMissionRefreshed
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

		public event Action<HttpStatusCode, string> OnMissionRefreshFailed
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

		public event Action OnMissionClaimed
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

		public event Action<bool> OnMissionHasClaimable
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

		protected override void Initialize()
		{
		}

		protected override void Dispose()
		{
		}

		public MissionRecordList GetCachedMissions(MissionTable missionTable)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestMissions_003Ed__24))]
		public void RequestMissions(MissionTable missionTable)
		{
		}

		private void SetRequestingMissions(MissionTable missionTable, bool isRequesting)
		{
		}

		private bool IsRequestingMissions(MissionTable missionTable)
		{
			return false;
		}

		private void HandleOnMissionRefreshed(MissionTable missionTable, MissionRecordList recordList)
		{
		}

		public void SendMissionClaimedEvent()
		{
		}

		public void SendMissionHasClaimableEvent(bool hasClaimable)
		{
		}

		private static int HandleSessionEnded(object _)
		{
			return 0;
		}

		private static void RecordMissionStartTime(MissionRecordList recordList)
		{
		}

		private static void UpdateMissionDurations()
		{
		}

		private static RecordList GetMissionDurationRecord()
		{
			return null;
		}

		private void LoadRecordedMissionStatus(MissionRecordList missionRecordList)
		{
		}

		private void RecordInProgressMissions(MissionRecordList missionRecordList)
		{
		}

		private void CompareAndLogRecordedMissions(MissionRecordList missionRecordList)
		{
		}

		private static void LogCompleteTask(string date, MissionRecord mission)
		{
		}

		private static void LogCompleteAllTasks(MissionRecordList missionRecordList)
		{
		}

		public static void CalculateRewards(IEnumerable<RewardItem> rewardItems, out int freeCurrenciesAmount, out int activityPointsAmount)
		{
			freeCurrenciesAmount = default(int);
			activityPointsAmount = default(int);
		}
	}
}
