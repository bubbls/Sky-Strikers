using System;
using System.Collections.Generic;
using UnityEngine;

namespace Moon.Player.Visual
{
	[Serializable]
	public class AttachPointAdjustmentCollection
	{
		[SerializeField]
		private List<AttachPointAdjustment> _adjustedTransforms;

		public void AdjustTransforms()
		{
		}
	}
}
