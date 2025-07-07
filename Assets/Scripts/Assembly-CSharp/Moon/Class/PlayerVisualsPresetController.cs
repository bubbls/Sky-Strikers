using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Runtime;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerVisualsPresetController : MonoBehaviour
	{
		[Serializable]
		private class PresetPoints : SerializableDictionary<PlayerSuitClass, PlayerVisualsPresetPoints>
		{
		}

		private const float PreloadDuration = 2f;

		[SerializeField]
		[Space(5f)]
		private PresetPoints _presetPoints;

		[SerializeField]
		private int _frameDelayBetweenSlotLoading;

		[SerializeField]
		private float _unloadVisualsDelay;

		[SerializeField]
		private float _deleteStateDuration;

		private PlayerVisualsPresetSlot[] _slots;

		private IMessageSubscriber[] _subscribers;

		private bool _isPendingUnload;

		private bool _isPresetsLoaded;

		private float _visualsUnloadStartTime;

		private Dictionary<PlayerVisualsPresetSlot, float> _slotsInDeleteState;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private int HandlePlayerLocationChangedMessage(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void PreloadPresets()
		{
		}

		private void ValidatePresets()
		{
		}

		private void LoadPlayerPresets()
		{
		}

		private PlayerVisualsPresetPoints GetPresetPoint(PlayerSuitClass suitClass)
		{
			return null;
		}

		private void Slot_OnSlotFunctionButtonPressed(PlayerVisualsPresetSlot slot, PlayerVisualsPresetSlotFunctionButton.State state)
		{
		}

		private void Slot_OnDeleteButtonPressed(PlayerVisualsPresetSlot slot)
		{
		}

		private void Slot_OnSlotVisualsLoaded(PlayerVisualsPresetSlot slot)
		{
		}

		private void Slot_OnPlayerEnteredSlotArea(PlayerVisualsPresetSlot slot)
		{
		}

		private void Slot_OnPlayerExitSlotArea(PlayerVisualsPresetSlot slot)
		{
		}

		private void PreviewPlayerVisualsInSlot(PlayerVisualsPresetSlot slot)
		{
		}

		private void SavePreset(PlayerVisualsPresetSlot slot)
		{
		}

		private void DeletePreset(PlayerVisualsPresetSlot slot)
		{
		}
	}
}
