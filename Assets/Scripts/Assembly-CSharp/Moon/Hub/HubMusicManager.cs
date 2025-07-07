using UnityEngine;

namespace Moon.Hub
{
	public class HubMusicManager : MonoBehaviour
	{
		[SerializeField]
		private JukeboxArea _hubJukeboxArea;

		[SerializeField]
		private JukeboxArea _shopJukeboxArea;

		[SerializeField]
		private JukeboxArea _hallOfHeroesJukeboxArea;

		[SerializeField]
		private JukeboxArea _loungeAreaJukeboxArea;

		private MusicArea _currentMusicArea;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnHubJukeboxVolumeChanged(bool hasPlayer)
		{
		}

		private void HandleOnShopJukeboxVolumeChanged(bool hasPlayer)
		{
		}

		private void HandleOnHallOfHeroesJukeboxVolumeChanged(bool hasPlayer)
		{
		}

		private void HandleOnLoungeAreaJukeboxVolumeChanged(bool hasPlayer)
		{
		}

		private void TryChangeMusic(JukeboxArea currentJukeboxArea, MusicArea changeTargetMusicArea)
		{
		}
	}
}
