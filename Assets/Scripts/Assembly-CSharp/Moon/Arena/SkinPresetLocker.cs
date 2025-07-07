using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Runtime;
using Fusion;
using Moon.Class;
using Moon.Hub;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class SkinPresetLocker : MonoBehaviour
	{
		[Serializable]
		private class PresetPoints : DP.Takeaway.Runtime.SerializableDictionary<PlayerSuitClass, PlayerVisualsPresetPoints>
		{
		}

		[CompilerGenerated]
		private sealed class _003CLoadRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkinPresetLocker _003C_003E4__this;

			public PlayerVisualsConfig config;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadRoutine_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private TMP_Text _nameText;

		[SerializeField]
		private GameObject _door;

		[SerializeField]
		private GameObject _noPresetsIndicator;

		[SerializeField]
		private GameObject _loadingIndicator;

		[SerializeField]
		private PlayerVisualsPresetLoader _visualsLoader;

		[SerializeField]
		private PresetPoints _presetPoints;

		[SerializeField]
		private ManualButton _equip;

		[SerializeField]
		private ManualButton _next;

		[SerializeField]
		private ManualButton _back;

		[SerializeField]
		private TeamNo _teamNo;

		private PlayerVisualsPresetPoints _playerVisualsPresetPoints;

		private int _curLoadedIndex;

		private int _curVisualConfigIndex;

		private int _maxVisualConfigsCount;

		private IEnumerator _currentLoadRoutine;

		private List<PlayerVisualsConfig> _visualsConfigs;

		private bool _isUsedByLocalPlayer;

		private IMessageSubscriber _subscribers;

		private PlayerRef _ownerRemotePlayer;

		private void Start()
		{
		}

		private void Equip_OnPressed()
		{
		}

		private void OnDisable()
		{
		}

		public void PrepareForLocalPlayer()
		{
		}

		public void Close()
		{
		}

		public void PrepareForOtherPlayer(PlayerRef player)
		{
		}

		private int HandleOnPlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void LoadNextPreset()
		{
		}

		private void LoadPreviousPreset()
		{
		}

		private void LoadPreset(int index)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadRoutine_003Ed__30))]
		private IEnumerator LoadRoutine(PlayerVisualsConfig config)
		{
			return null;
		}

		private void UnloadLocalPlayerFunctions()
		{
		}

		private PlayerVisualsPresetPoints GetPresetPoint(PlayerSuitClass suitClass)
		{
			return null;
		}

		private void TryUnloadCurrentVisuals()
		{
		}

		private void ToggleNavigationButtons(bool enable)
		{
		}

		private void ToggleButtonVisibility(bool show)
		{
		}
	}
}
