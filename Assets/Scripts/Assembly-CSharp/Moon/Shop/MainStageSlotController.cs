using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Moon.Economy;
using UnityEngine;

namespace Moon.Shop
{
	public class MainStageSlotController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MainStageSlotController _003C_003E4__this;

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

		[SerializeField]
		private SaleSlot _defaultMainStageSlot;

		[SerializeField]
		private RechargeSlot _introPackSlot;

		[SerializeField]
		private RechargeSlotDefault _defaultRechargeSlot;

		private readonly Cooldown _cooldown;

		private IMessageSubscriber? _subscriber;

		private bool _canUpdate;

		private PlayerEconomy? _playerEconomy;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__11))]
		private void Start()
		{
		}

		private int HandleOnCurrencyProductsUpdated(IMessage<object> _)
		{
			return 0;
		}

		private void UpdateMainStage()
		{
		}

		private void HandleSlotUpdated()
		{
		}

		private void Update()
		{
		}

		private void HandleOnTryUpdateMainStageSlot()
		{
		}

		private void SetupMainStageSlot()
		{
		}
	}
}
