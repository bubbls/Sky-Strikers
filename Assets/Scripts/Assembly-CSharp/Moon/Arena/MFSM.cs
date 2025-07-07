using System;
using System.Collections.Generic;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(17)]
	public class MFSM : NetworkBehaviour
	{
		private class State
		{
			public string Name;

			public StateFunction Func;
		}

		private class Transition
		{
			public string Target;

			public Action PreTransitionAction;

			public ConditionFunction Condition;
		}

		public enum Phase
		{
			OnEnter = 0,
			OnUpdate = 1,
			OnExit = 2
		}

		public delegate void StateFunction(Phase phase);

		public delegate bool ConditionFunction();

		[DefaultForProperty("CurrState", 0, 17)]
		[SerializeField]
		private NetworkString<_16> _CurrState;

		private string _currStateValueCache;

		private readonly Dictionary<string, State> _states;

		private readonly Dictionary<string, List<Transition>> _transitions;

		private State _currState;

		private static Changed<MFSM> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MFSM> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MFSM> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 17)]
		[Networked(OnChanged = "OnCurrStateChanged")]
		public NetworkString<_16> CurrState
		{
			get
			{
				return default(NetworkString<_16>);
			}
			private set
			{
			}
		}

		public string CurrStateValue => null;

		public override void Spawned()
		{
		}

		public void AddTransition(string stateA, string stateB, ConditionFunction condition, Action preTransitionAction = null)
		{
		}

		public void Register(string stateName, StateFunction stateFunc)
		{
		}

		public void SetState(string stateName)
		{
		}

		private void SetCurrentState()
		{
		}

		[Preserve]
		private static void OnCurrStateChanged(Changed<MFSM> changed)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void UpdateCurrentState(Phase phase)
		{
		}

		private void UpdateCurrentTransitions()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
