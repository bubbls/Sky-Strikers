using SVGImporter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Hub
{
	public class VoteMachineOptionView : MonoBehaviour
	{
		private const string GameModePath = "VoteMachine/GameModes/";

		private const string GameModeModifierPath = "VoteMachine/GameModeModifiers/";

		[SerializeField]
		private TMP_Text _totalVotes;

		[SerializeField]
		private TMP_Text _gameModeTitle;

		[SerializeField]
		private RawImage _gameModeImage;

		[SerializeField]
		private TMP_Text _modifierTitle;

		[SerializeField]
		private RawImage _modifierImage;

		[SerializeField]
		private SVGImage _background;

		[SerializeField]
		private SVGAsset _votedBackground;

		[SerializeField]
		private SVGAsset _notVotedBackground;

		private VoteMachineDisplayOption _displayOption;

		private void OnDestroy()
		{
		}

		public void UpdateVoteCount(int count)
		{
		}

		public void ApplyGameSettings(HubGameSettings gameSettings)
		{
		}

		public void ToggleVotedVisuals(bool isVoted)
		{
		}

		private void ConfigureDisplayTexture(string path, ref TMP_Text displayName, ref RawImage rawImage)
		{
		}
	}
}
