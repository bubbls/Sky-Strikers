using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace VRKeys
{
	public class Keyboard : MonoBehaviour
	{
		[Serializable]
		public class KeyboardUpdateEvent : UnityEvent<string>
		{
		}

		[Serializable]
		public class KeyboardSubmitEvent : UnityEvent<string>
		{
		}

		[CompilerGenerated]
		private sealed class _003CDelayToggleShift_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Keyboard _003C_003E4__this;

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
			public _003CDelayToggleShift_003Ed__51(int _003C_003E1__state)
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
		private sealed class _003CDoSetLanguage_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Keyboard _003C_003E4__this;

			public KeyboardLayout lang;

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
			public _003CDoSetLanguage_003Ed__58(int _003C_003E1__state)
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
		private sealed class _003CDoSetPlaceholderMessage_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Keyboard _003C_003E4__this;

			public string msg;

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
			public _003CDoSetPlaceholderMessage_003Ed__60(int _003C_003E1__state)
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
		private sealed class _003CEnableWhenInitialized_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Keyboard _003C_003E4__this;

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
			public _003CEnableWhenInitialized_003Ed__46(int _003C_003E1__state)
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
		private sealed class _003CSetupKeys_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Keyboard _003C_003E4__this;

			private bool _003CactiveState_003E5__2;

			private int _003CkeyCount_003E5__3;

			private int _003Ci_003E5__4;

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
			public _003CSetupKeys_003Ed__67(int _003C_003E1__state)
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
		private sealed class _003CStart_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Keyboard _003C_003E4__this;

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
			public _003CStart_003Ed__40(int _003C_003E1__state)
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

		public Vector3 positionRelativeToUser;

		public KeyboardLayout keyboardLayout;

		[Space(15f)]
		public TextMeshProUGUI placeholder;

		public string placeholderMessage;

		public TextMeshProUGUI displayText;

		public GameObject validationNotice;

		public TextMeshProUGUI validationMessage;

		public GameObject infoNotice;

		public TextMeshProUGUI infoMessage;

		public GameObject successNotice;

		public TextMeshProUGUI successMessage;

		[Space(15f)]
		public Color displayTextColor;

		public Color caretColor;

		[Space(15f)]
		public GameObject keyPrefab;

		public Transform keysParent;

		public float keyWidth;

		public float keyHeight;

		[Space(15f)]
		public string text;

		[Space(15f)]
		public GameObject canvas;

		public GameObject leftMallet;

		public GameObject rightMallet;

		public GameObject keyboardWrapper;

		public ShiftKey shiftKey;

		public Key[] extraKeys;

		[Space(15f)]
		public bool leftPressing;

		public bool rightPressing;

		public bool initialized;

		public bool disabled;

		[Space(15f)]
		public KeyboardUpdateEvent OnUpdate;

		public KeyboardSubmitEvent OnSubmit;

		public UnityEvent OnCancel;

		private GameObject playerSpace;

		private GameObject leftHand;

		private GameObject rightHand;

		private LetterKey[] keys;

		private bool shifted;

		private Layout layout;

		[SerializeField]
		private Transform _trackingOffset;

		[IteratorStateMachine(typeof(_003CStart_003Ed__40))]
		private IEnumerator Start()
		{
			return null;
		}

		private void Update()
		{
		}

		private void PositionAndAttachMallets()
		{
		}

		private void DetachMallets()
		{
		}

		private void OnDisable()
		{
		}

		[ContextMenu("Enable Keyboard")]
		public void Enable()
		{
		}

		[IteratorStateMachine(typeof(_003CEnableWhenInitialized_003Ed__46))]
		private IEnumerator EnableWhenInitialized()
		{
			return null;
		}

		public void Disable()
		{
		}

		public void SetText(string txt)
		{
		}

		public void AddCharacter(string character)
		{
		}

		public bool ToggleShift()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CDelayToggleShift_003Ed__51))]
		private IEnumerator DelayToggleShift()
		{
			return null;
		}

		public void DisableInput()
		{
		}

		public void EnableInput()
		{
		}

		public void Backspace()
		{
		}

		public void Submit()
		{
		}

		public void Cancel()
		{
		}

		public void SetLayout(KeyboardLayout layout)
		{
		}

		[IteratorStateMachine(typeof(_003CDoSetLanguage_003Ed__58))]
		private IEnumerator DoSetLanguage(KeyboardLayout lang)
		{
			return null;
		}

		public void SetPlaceholderMessage(string msg)
		{
		}

		[IteratorStateMachine(typeof(_003CDoSetPlaceholderMessage_003Ed__60))]
		private IEnumerator DoSetPlaceholderMessage(string msg)
		{
			return null;
		}

		public void ShowValidationMessage(string message)
		{
		}

		public void ShowInfoMessage(string message)
		{
		}

		public void ShowSuccessMessage(string message)
		{
		}

		public void HideValidationMessage()
		{
		}

		public void HideInfoMessage()
		{
		}

		public void HideSuccessMessage()
		{
		}

		[IteratorStateMachine(typeof(_003CSetupKeys_003Ed__67))]
		private IEnumerator SetupKeys()
		{
			return null;
		}

		private void UpdateDisplayText()
		{
		}

		private void PlaceholderVisibility()
		{
		}

		public void SetTrackingOffset(Transform trans)
		{
		}
	}
}
