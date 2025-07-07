using UnityEngine;

namespace Moon.Hub
{
	public class HubMinimap : MonoBehaviour
	{
		[SerializeField]
		private HubMinimapPopup _popup;

		private HubMinimapPointOfInterest[] _pointsOfInterest;

		[SerializeField]
		private LocalPlayerCheckVolume _localPlayerCheckVolume;

		private HubMinimapPointOfInterest _currentSelectedPoi;

		private void Start()
		{
		}

		private void Poi_OnPOISelected(HubMinimapPointOfInterest poi, bool isOn)
		{
		}

		private void LocalPlayerCheckVolume_OnChanged(bool hasPlayer)
		{
		}
	}
}
