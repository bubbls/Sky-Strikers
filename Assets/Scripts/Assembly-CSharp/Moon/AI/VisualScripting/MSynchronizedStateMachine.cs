using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.AI.VisualScripting
{
	public class MSynchronizedStateMachine : MTask
	{
		private enum Context
		{
			StateAuthority = 0,
			Player = 1
		}

		private const string EventOnStateChanged = "OnStateChanged";

		[SerializeField]
		private Context _context;

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[Preserve]
		public void SetState(int state)
		{
		}

		private void HandleStateChanged(int state)
		{
		}

		public override void Spawned()
		{
		}
	}
}
