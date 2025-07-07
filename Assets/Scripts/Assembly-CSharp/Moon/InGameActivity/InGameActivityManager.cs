using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using Moon.Mission;
using PlayFab;
using UnityEngine;

namespace Moon.InGameActivity
{
	public class InGameActivityManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetGameActivityInfo_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InGameActivityInfoResponseData> _003C_003Et__builder;

			public InGameActivityManager _003C_003E4__this;

			private TaskAwaiter<InGameActivityInfoResponseData> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateGameActivityInfoAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public InGameActivityManager _003C_003E4__this;

			private TaskAwaiter<InGameActivityInfoResponseData> _003C_003Eu__1;

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

		[Header("Mission")]
		[Space(5f)]
		[SerializeField]
		private List<MissionBoardController> _missionBoardsController;

		[Header("Visuals")]
		[Space(5f)]
		[SerializeField]
		private InGameActivityVisualManager _visualManager;

		[SerializeField]
		[Space(5f)]
		[Header("Reward")]
		private InGameActivityReward _activityReward;

		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		private IMessageSubscriber[] _subscribers;

		private float _nextTimeUpdateDataContributionLeaderboard;

		private void OnEnable()
		{
		}

		private int HandleOnLeaderboardUpdated(IMessage<object> message)
		{
			return 0;
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateGameActivityInfoAsync_003Ed__11))]
		private void UpdateGameActivityInfoAsync()
		{
		}

		private void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CGetGameActivityInfo_003Ed__13))]
		private Task<InGameActivityInfoResponseData> GetGameActivityInfo()
		{
			return null;
		}
	}
}
