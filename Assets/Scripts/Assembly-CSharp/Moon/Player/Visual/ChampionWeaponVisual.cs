using Chamber8.Framework.Messaging;
using Fusion;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Visual
{
	public class ChampionWeaponVisual : MonoBehaviour, IVisualEventReceiver
	{
		private const float DisableDelay = 0.5f;

		[SerializeField]
		private bool _requestWeaponStatusOnSpawn;

		[SerializeField]
		private GameObject _uiContainer;

		[SerializeField]
		private Image _rankIcon;

		[SerializeField]
		private TMP_Text _statText;

		[SerializeField]
		private Color _defaultStatTextColor;

		[SerializeField]
		private Color _tempStatTextColor;

		[SerializeField]
		private ChampionWeaponFx[] _weaponFxs;

		[SerializeField]
		private LayoutGroup _uiLayoutGroup;

		[SerializeField]
		private CustomAttachPointAdjustments _attachPointAdjustments;

		private PlayerRef _weaponOwner;

		private IMessageSubscriber[] _messageSubscribers;

		private int _cachedMmr;

		private int _cachedStat;

		private bool _disableLayoutGroupPending;

		private float _disableTime;

		private IVisualEventNotifier _visualEventNotifier;

		public void HandleOnVisualReceived(IVisualEventNotifier visual)
		{
		}

		private void InitializeVisual(PlayerRef ownerPlayer, PlayerVisualAttachPointType attachPointType, bool isLocalPlayerVisual)
		{
		}

		private void DisposeVisual()
		{
		}

		private void RemoveVisualEventNotifierEvents()
		{
		}

		private void SetOwner(PlayerRef ownerPlayer)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandleOnChampionWeaponStatusUpdated(IMessage<ChampionWeaponStatusUpdatedMessage> message)
		{
			return 0;
		}

		private void ToggleWeaponFx(bool visible)
		{
		}

		private void EnableLayoutGroupTemporarily()
		{
		}
	}
}
