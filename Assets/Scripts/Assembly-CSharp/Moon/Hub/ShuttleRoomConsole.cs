using DP.Takeaway.Utils;
using DP.Takeaway.VisualScripting;
using Moon.Arena;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class ShuttleRoomConsole : MonoBehaviour
	{
		[SerializeField]
		private ShuttleRoomRegionSelector _regionSelector;

		[SerializeField]
		private ShuttleRoomSessionNamePad _sessionNamePad;

		[SerializeField]
		private ShuttleRoomToggle _publicSessionToggle;

		[SerializeField]
		private TMP_Text _textRtt;

		[SerializeField]
		private TMP_Text _textTargetPlace;

		[SerializeField]
		private GameObject _pagePublic;

		[SerializeField]
		private GameObject _pagePrivate;

		[Header("Match Buttons")]
		[SerializeField]
		private GameObject _btnMatchNormal;

		[SerializeField]
		private GameObject _btnMatchHalloween;

		private readonly Cooldown _updateCd;

		private CustomEventHandler _customEventHandler;

		public string RoomName => null;

		[field: Header("Public/Private")]
		public bool IsPublic { get; private set; }

		public FieldType FieldType { get; private set; }

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

		private void HandlePublicSessionToggle()
		{
		}

		private void UpdateTargetPlace()
		{
		}

		private void UpdatePublicSessionToggle()
		{
		}

		private void UpdateMatchButtons()
		{
		}

		private void HandleRoomNameChanged()
		{
		}

		private void HandleRegionChanged()
		{
		}

		private void Update()
		{
		}

		private void HandleBtnPressed(string btnName)
		{
		}
	}
}
