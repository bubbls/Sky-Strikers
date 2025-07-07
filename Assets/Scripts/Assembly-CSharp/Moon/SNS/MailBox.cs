using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using Chamber8.Framework.Service.Rpc;
using Moon.Hub;
using Moon.Shop;
using NaughtyAttributes;
using PlayFab.EconomyModels;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.SNS
{
	public class MailBox : MonoBehaviour
	{
		private enum State
		{
			Listing = 0,
			ReadingContent = 1,
			Processing = 2,
			Completing = 3,
			ClaimingEquipment = 4,
			Error = 5
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public TaskCompletionSource<int> tcs;

			internal void _003CShowClaimedResultRoutine_003Eb__0(Response response)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowClaimedResultRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MailBox _003C_003E4__this;

			public ClaimMailResult result;

			private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

			private int _003CcoinAmount_003E5__2;

			private List<(CatalogItem Item, int Amount)> _003Cjoyos_003E5__3;

			private List<CatalogItem> _003Cothers_003E5__4;

			private int _003CsoundId_003E5__5;

			private WaitForSeconds _003Cwait_003E5__6;

			private List<CatalogItem>.Enumerator _003C_003E7__wrap6;

			private float _003Cexpire_003E5__8;

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
			public _003CShowClaimedResultRoutine_003Ed__27(int _003C_003E1__state)
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
		}

		[CompilerGenerated]
		private sealed class _003CShowCoinsRoutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MailBox _003C_003E4__this;

			public int amount;

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
			public _003CShowCoinsRoutine_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CShowErrorRoutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MailBox _003C_003E4__this;

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
			public _003CShowErrorRoutine_003Ed__32(int _003C_003E1__state)
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
		private sealed class _003CShowJCRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MailBox _003C_003E4__this;

			public int amount;

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
			public _003CShowJCRoutine_003Ed__30(int _003C_003E1__state)
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

		private const string SourceMailBox = "mailbox";

		private const string TextClaimingEquipment = "YOU HAVE RECEIVED A NEW EQUIPMENT {0}";

		private const float SkinAppearingDuration = 5f;

		[SerializeField]
		private NewMailFlag _newMailFlag;

		[SerializeField]
		private MailListPanel _listPanel;

		[SerializeField]
		private MailContentPanel _contentPanel;

		[SerializeField]
		private PushLockButton _btnClaim;

		[SerializeField]
		private GameObject _errorPanel;

		[SerializeField]
		private GameObject _processingPanel;

		[SerializeField]
		private GameObject _completingPanel;

		[SerializeField]
		private GameObject _claimingEquipmentPanel;

		[SerializeField]
		private UnityEngine.UI.Image _claimingItemIcon;

		[SerializeField]
		private TMP_Text _claimingItemText;

		[SerializeField]
		private Transform _joyoSpawnPosition;

		[SerializeField]
		private CurrencyNotificationArea _notificationArea;

		[SerializeField]
		private CurrencyTransactionTubeRendererController _tubeController;

		[SerializeField]
		private ManualToggle _mouthToggle;

		private State _state;

		private Coroutine? _processRoutine;

		private IMessageSubscriber? _subscriber;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleMailReceived()
		{
		}

		private void Start()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void ListMails()
		{
		}

		private int OnRefreshMailList(IMessage<object> _)
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CShowClaimedResultRoutine_003Ed__27))]
		private IEnumerator ShowClaimedResultRoutine(ClaimMailResult? result)
		{
			return null;
		}

		private string GetLastPartOfFriendlyId(string friendlyId)
		{
			return null;
		}

		private void ShowClaimingEquipmentPanel(CatalogItem item)
		{
		}

		[IteratorStateMachine(typeof(_003CShowJCRoutine_003Ed__30))]
		private IEnumerator ShowJCRoutine(int amount)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowCoinsRoutine_003Ed__31))]
		private IEnumerator ShowCoinsRoutine(int amount)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowErrorRoutine_003Ed__32))]
		private IEnumerator ShowErrorRoutine()
		{
			return null;
		}

		[Button(null, EButtonEnableMode.Always)]
		private void TestSpawnJoyos()
		{
		}

		private void HandleClaiming()
		{
		}

		private void HandleCloseContentPanel()
		{
		}

		private void HandleClickedMail(MailItem mail)
		{
		}

		private void UpdateVisuals()
		{
		}
	}
}
