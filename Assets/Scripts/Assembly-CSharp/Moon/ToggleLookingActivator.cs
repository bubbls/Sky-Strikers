using DP.Takeaway.Utils;
using Moon.Commands;
using UnityEngine;

namespace Moon
{
	public class ToggleLookingActivator : CommandProvider
	{
		private class Command : PlayerCommand
		{
			public bool ToggleOn;

			protected override void Execute(LocalPlayerRig localPlayerRig)
			{
			}
		}

		[SerializeField]
		private bool _toggleOn;

		private Command _command;

		public override ICommand GetCommand()
		{
			return null;
		}
	}
}
