using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.MultiPlay;
using SVGImporter;
using UnityEngine;

namespace Moon.Class
{
	public class ClassSwitchRoomUIController : MonoBehaviour
	{
		[SerializeField]
		private ClassSwitchRoomSetting _roomSetting;

		[SerializeField]
		private SVGRenderer _detailSvgRenderer;

		[SerializeField]
		private SVGRenderer _leftIntroSvgRenderer;

		[SerializeField]
		private SVGRenderer _rightIntroSvgRenderer;

		[SerializeField]
		private ClassChangeRoomConfirm[] _confirms;

		[SerializeField]
		private string _analyticsSource;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private PlayerSuitClass _currentSuitClass;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnClassSwitchConfirmed(PlayerSuitClass playerSuitClass)
		{
		}

		private void OnDestroy()
		{
		}

		private void RefreshDisplay(ClassDisplaySetting setting)
		{
		}

		private void Confirm(PlayerSuitClass suitClass)
		{
		}

		private ClassDisplaySetting GetDisplaySetting(PlayerSuitClass suitClass)
		{
			return null;
		}

		private SVGAsset GetSvgAsset(ClassDisplaySetting.DisplaySVG[] displaySettings, ClassDisplaySetting.DisplayState state)
		{
			return null;
		}

		private void ChangeVisualTheme(PlayerSuitClass suitClass)
		{
		}

		private int HandleMPlayerSpawnedMessage(IMessage<MPlayer> message)
		{
			return 0;
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}
	}
}
