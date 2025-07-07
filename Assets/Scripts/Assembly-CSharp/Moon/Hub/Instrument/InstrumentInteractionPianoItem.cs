using System.Collections.Generic;
using UnityEngine;

namespace Moon.Hub.Instrument
{
	public class InstrumentInteractionPianoItem : InstrumentInteractionItem
	{
		[SerializeField]
		private MeshFilter _meshFilter;

		[SerializeField]
		private List<Mesh> _keyMeshes;

		private int _pianoType;

		protected override bool CanInteract(Collider other)
		{
			return false;
		}

		public void SwitchKeyboard(MPiano.PianoType pianoType, int pianoTypeCount)
		{
		}

		protected override void PlaySound()
		{
		}
	}
}
