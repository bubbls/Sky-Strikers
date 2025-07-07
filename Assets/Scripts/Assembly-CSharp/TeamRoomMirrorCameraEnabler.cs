using Moon;
using UnityEngine;

public class TeamRoomMirrorCameraEnabler : MonoBehaviour
{
	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private LocalPlayerCheckVolume _localPlayerCheckVolume;

	private void Start()
	{
	}

	private void OnLocalPlayerChanged(bool hasPlayer)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
