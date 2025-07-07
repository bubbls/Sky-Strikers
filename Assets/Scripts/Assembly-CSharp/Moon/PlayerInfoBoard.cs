using DP.Takeaway.Utils;
using Fusion;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class PlayerInfoBoard : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textInfo;

		private Cooldown _cooldown;

		private PlayerRef _playerRef;

		private PlayerVisualsController _controller;

		public void BindPlayerRef(PlayerVisualsController controller, PlayerRef playerRef)
		{
		}

		public void UnbindPlayerRef()
		{
		}

		private void Update()
		{
		}

		private void RefreshInfo()
		{
		}
	}
}
