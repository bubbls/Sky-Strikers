using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub.Instrument
{
	[NetworkBehaviourWeaved(1)]
	public class MPiano : MInstrument
	{
		public enum PianoType
		{
			White = 0,
			Red = 1,
			Colorful = 2
		}

		private static readonly HapticImpulse HapticImpulse;

		[SerializeField]
		private ManualButton _switchKeyboardButton;

		[DefaultForProperty("CurrentKeyboardIndex", 0, 1)]
		private int _CurrentKeyboardIndex;

		private int _pianoTypeCount;

		private static Changed<MPiano> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPiano> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPiano> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleOnKeyboardSwitched")]
		[NetworkedWeaved(0, 1)]
		private int CurrentKeyboardIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void Spawned()
		{
		}

		private void SwitchKeyboard()
		{
		}

		private void OnSwitchKeyboardButtonPressed()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void Rpc_SwitchKeyboard()
		{
		}

		[Preserve]
		private static void HandleOnKeyboardSwitched(Changed<MPiano> changed)
		{
		}

		protected override HapticImpulse GetHapticImpulse()
		{
			return null;
		}

		protected override void TrackingAnalytics()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 7, 1)]
		protected unsafe static void Rpc_SwitchKeyboard_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
