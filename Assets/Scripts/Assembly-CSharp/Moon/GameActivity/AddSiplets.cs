using System.Collections.Generic;
using DP.Takeaway.Utils;
using Moon.Commands;
using UnityEngine;

namespace Moon.GameActivity
{
	public class AddSiplets : ICommand, IPowerUpResult
	{
		private SipletsTrail _trail;

		public bool Success { get; private set; }

		public int Diff { get; private set; }

		public AddSiplets(IReadOnlyList<Transform> emitPositions, int amount)
		{
		}

		public void Accept(ICommandExecutor executor)
		{
		}
	}
}
