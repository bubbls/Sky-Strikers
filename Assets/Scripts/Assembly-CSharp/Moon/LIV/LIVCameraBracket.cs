using UnityEngine;

namespace Moon.LIV
{
	public class LIVCameraBracket : MonoBehaviour
	{
		[SerializeField]
		private GameObject _livCameraPrefab;

		[SerializeField]
		private float _checkDistance;

		[SerializeField]
		private Transform _placeCameraPoint;

		[SerializeField]
		private LocalPlayerCheckVolume _localPlayerCheck;

		[SerializeField]
		private GameObject _noticeGameObject;

		[SerializeField]
		private float _stayTime;

		private const string CameraBracketNoticeKey = "CameraBracketNoticeKey";

		private float _distance;

		private int _stayTimerId;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LocalPlayerCheckVolume_OnChanged(bool hasPlayer)
		{
		}

		private void MarkStayedInCameraBracket()
		{
		}

		private void CancelStayTimer()
		{
		}

		private void ToggleNoticeMark(bool enable)
		{
		}

		private void LIVCameraLocalGrabbable_HandleOnReleased()
		{
		}

		private void LateUpdate()
		{
		}

		private float GetCameraAndBracketDistance()
		{
			return 0f;
		}
	}
}
