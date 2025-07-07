using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class VoteMachineUI : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _votesRequiredText;

		[SerializeField]
		private float _minVotesCountTextSize;

		[SerializeField]
		private Color _minVotesCountTextColor;

		[SerializeField]
		private VoteMachineOptionView _optionOneView;

		[SerializeField]
		private VoteMachineOptionView _optionTwoView;

		[SerializeField]
		private HubVoteButton _optionOneButton;

		[SerializeField]
		private HubVoteButton _optionTwoButton;

		[SerializeField]
		private TMP_Text _timerText;

		public event Action OnOptionOneButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnOptionTwoButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		public void SetInitialVotes(int optionOneVotes, int optionTwoVotes)
		{
		}

		private void OptionOneButton_OnPressed()
		{
		}

		private void OptionTwoButton_OnPressed()
		{
		}

		public void UpdateVotes(int optionOneVotes, int optionTwoVotes, int minVotes, bool shouldHideMinVotesText)
		{
		}

		public void UpdateVoteRemainingTime(int seconds)
		{
		}

		public void ResetVotingButtons()
		{
		}

		public void ConfigureForVoting(HubGameSettings optionOne, HubGameSettings optionTwo)
		{
		}

		private void ConfigureOption(HubGameSettings gameSettings, VoteMachineOptionView optionView)
		{
		}
	}
}
