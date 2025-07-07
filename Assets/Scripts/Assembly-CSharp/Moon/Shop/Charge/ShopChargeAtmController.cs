using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Moon.Shop.Charge
{
	public class ShopChargeAtmController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayGlassAnimation_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ShopChargeAtmController _003C_003E4__this;

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
		private List<ParticleSystem> _brokenParticles;

		[Space(5f)]
		[SerializeField]
		[Header("Rotate Components")]
		private ShopChargeAtmRotateComponent _atmTextRotateComponent;

		[SerializeField]
		private List<ShopChargeAtmRotateComponent> _gearsRotateComponents;

		[SerializeField]
		private List<ShopChargeAtmRotateComponent> _brokenGearsRotateComponents;

		[SerializeField]
		private List<ShopChargeAtmEnergyBar> _energyBars;

		[SerializeField]
		private Animator _animInjectEnergy;

		[SerializeField]
		private ShopChargeAtmGate _gateComponent;

		[SerializeField]
		private AnimationNumbersText _animationText;

		[SerializeField]
		private ShopChargeAtmVisuals _atmVisuals;

		[SerializeField]
		private Canvas _atmCanvas;

		[SerializeField]
		private Animation _atmAnimation;

		[SerializeField]
		private Material _atmGlassMat;

		private static readonly int _injectEnergy;

		private static readonly int _levelingWidth;

		private static readonly int _levelingMove;

		private bool _atmGlassMatWorking;

		public void Initialize()
		{
		}

		public void ShowIdleState()
		{
		}

		public void ShowRechargingState(int index)
		{
		}

		public void ShowRecoveringState()
		{
		}

		public void ShowCompleteState(int targetNumber, Action callback)
		{
		}

		public void ShowCompleteToIdleState(Action callback)
		{
		}

		public void DecreaseChargeAmountText(int currentNumber, Action completed = null, float waitingTime = 0f, Action started = null)
		{
		}

		public void ShowIapReceiptConsumeFailedState()
		{
		}

		public void StopRechargingState()
		{
		}

		private void StopBrokenEffects()
		{
		}

		private void OnDestroy()
		{
		}

		public void ToggleScreen(bool enable)
		{
		}

		public void OnUpdateMessage(ShopChargeScreenStatus status)
		{
		}

		[AsyncStateMachine(typeof(_003CPlayGlassAnimation_003Ed__29))]
		public void PlayGlassAnimation()
		{
		}

		public void StopGlassAnimation()
		{
		}
	}
}
