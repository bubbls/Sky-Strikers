using UnityEngine;

namespace Moon.Hub
{
	[CreateAssetMenu(menuName = "Moon/VoteMachine/Vote Machine Display Option", fileName = "VoteMachineDisplayOption")]
	public class VoteMachineDisplayOption : ScriptableObject
	{
		[SerializeField]
		private string _displayName;

		[SerializeField]
		private Texture2D _imageTexture;

		public string DisplayName => null;

		public Texture2D ImageTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
