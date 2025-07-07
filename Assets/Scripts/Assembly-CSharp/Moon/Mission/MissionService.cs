using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using PlayFab;
using UnityEngine.Scripting;

namespace Moon.Mission
{
	[Preserve]
	public class MissionService : IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetMissionsAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MissionRecordList> _003C_003Et__builder;

			public MissionTable missionTable;

			public MissionService _003C_003E4__this;

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

		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		private const string ArgMissionTableName = "MissionTable";

		private const string ArgMissionFriendlyIdList = "MissionFriendlyIdList";

		public void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CGetMissionsAsync_003Ed__4))]
		public Task<MissionRecordList> GetMissionsAsync(MissionTable missionTable)
		{
			return null;
		}

		public void GetMissions(MissionTable missionTable, Action<MissionRecordList> onSuccess, Action<HttpStatusCode, string> onError)
		{
		}

		public void ClaimReward(IEnumerable<string> friendlyIds, MissionTable missionTable, Action onSuccess, Action<HttpStatusCode, string> onError)
		{
		}
	}
}
