using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class HubVoteButton : ManualToggle
	{
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[SerializeField]
		private Material _votedMaterial;

		[SerializeField]
		private Color _votedTextColor;

		[SerializeField]
		private Material _selectableMaterial;

		[SerializeField]
		private Color _selectableTextColor;

		[SerializeField]
		private TMP_Text _text;

		public void SetVotedState()
		{
		}

		public void SetVoteSelectableState()
		{
		}
	}
}
