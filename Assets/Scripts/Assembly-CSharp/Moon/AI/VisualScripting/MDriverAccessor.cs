using Fusion;
using UnityEngine;

namespace Moon.AI.VisualScripting
{
	public abstract class MDriverAccessor : MonoBehaviour, IGameObjectAccessor
	{
		protected MStateMachineDriver StateMachineDriver { get; private set; }

		protected NetworkRunner Runner => null;

		public GameObject GameObject { get; private set; }

		protected virtual void Awake()
		{
		}
	}
}
