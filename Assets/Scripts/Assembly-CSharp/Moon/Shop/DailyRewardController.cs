using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;
using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon.Shop
{
	public class DailyRewardController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayGlassAnimation_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public DailyRewardController _003C_003E4__this;

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
		private GameObject _pedestal;

		[SerializeField]
		private DailyRewardClaimPanel _claimPanel;

		[SerializeField]
		private DailyRewardDisplayPanel _displayPanel;

		[SerializeField]
		private DailyRewardSetting _juiceSetting;

		[SerializeField]
		private DailyRewardSetting _currencySetting;

		[SerializeField]
		private DailyRewardClaimBtn _claimBtn;

		[SerializeField]
		private Transform _lightRoot;

		[SerializeField]
		private CurrencyNotificationArea _notificationArea;

		[SerializeField]
		private GameObject _lightDefault;

		[SerializeField]
		private Material _glassMat;

		private bool _glassMatWorking;

		private int _soundId;

		private DailyRewardService _dailyRewardService;

		private DailyRewardConfig _dailyRewardConfig;

		private DailyRewardInfo _dailyRewardInfo;

		private PlayFabCatalogItemService _catalogItemService;

		private Cooldown _cooldown;

		private const string DailyRewardClaimBtn = "DailyRewardClaimBtn";

		private Transform _lookTarget;

		private bool _claiming;

		private GameObject _lightObj;

		private static readonly int _levelingWidth;

		private static readonly int _levelingMove;

		private static readonly int _levelingColor;

		private static readonly int _levelingColor2;

		private bool _canUpdate;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void RequestCloudApi()
		{
		}

		private void InitializeClaimPanel()
		{
		}

		private void Update()
		{
		}

		private void HandleOnButtonPressed(string buttonName)
		{
		}

		private void RefreshActivateNode()
		{
		}

		private Transform GetLookTarget()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPlayGlassAnimation_003Ed__35))]
		private void PlayGlassAnimation()
		{
		}

		private void StopGlassAnimation()
		{
		}
	}
}
