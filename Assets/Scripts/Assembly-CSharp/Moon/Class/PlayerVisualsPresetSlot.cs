using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Moon.Arena;
using Moon.Hub;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Class
{
	[RequireComponent(typeof(PlayerVisualsPresetLoader))]
	public class PlayerVisualsPresetSlot : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerVisualsPresetSlot _003C_003E4__this;

			public PlayerVisualsPresetPoints pointsPrefab;

			public float delay;

			public PlayerVisualsConfig visualsConfig;

			object? IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object? IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadRoutine_003Ed__41(int _003C_003E1__state)
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
		private GameObject? _loadingIndicator;

		[SerializeField]
		private LocalPlayerCheckVolume? _localPlayerCheckVolume;

		[SerializeField]
		private PlayerVisualsPresetSlotFunctionButton? _functionButton;

		[SerializeField]
		private ManualButton? _deleteButton;

		[SerializeField]
		private PlayerVisualsPresetLoader _visualsLoader;

		[SerializeField]
		private bool _overrideTeam;

		[ShowIf("_overrideTeam")]
		[SerializeField]
		private TeamNo _teamNo;

		[SerializeField]
		private Transform? _transform;

		private PlayerVisualsPresetPoints? _presetPoints;

		private bool _isLoadingVisuals;

		private readonly WaitForEndOfFrame _waitForEndOfFrame;

		public PlayerVisualsConfig? VisualsConfig { get; private set; }

		public bool IsPreviewingVisuals { get; private set; }

		public event Action<PlayerVisualsPresetSlot>? OnDeleteButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PlayerVisualsPresetSlot>? OnSlotVisualsLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PlayerVisualsPresetSlot>? OnPlayerEnteredSlotArea
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PlayerVisualsPresetSlot>? OnPlayerExitSlotArea
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PlayerVisualsPresetSlot, PlayerVisualsPresetSlotFunctionButton.State>? OnSlotFunctionButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

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

		public void ToggleCheckingVolume(bool enable)
		{
		}

		public void Load(PlayerVisualsConfig data, PlayerVisualsPresetPoints pointsPrefab, bool isPreview, float delay = 0f)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadRoutine_003Ed__41))]
		private IEnumerator LoadRoutine(PlayerVisualsConfig visualsConfig, PlayerVisualsPresetPoints pointsPrefab, float delay)
		{
			return null;
		}

		public void SwitchFromHologramToOriginalVisualsColors(TeamNo teamNo)
		{
		}

		public void TryShowOriginalVisualsColors(TeamNo teamNo)
		{
		}

		private void ShowOriginalVisualsColors(TeamNo teamNo)
		{
		}

		private void ShowVisualsAsHologram()
		{
		}

		public void Unload()
		{
		}

		private void ClearLoadedVisuals()
		{
		}

		private void DestroyPoints()
		{
		}

		private void FunctionButton_OnPressed()
		{
		}

		private void DeleteButton_OnPressed()
		{
		}

		private void ToggleDeleteButton(bool enable)
		{
		}

		public void SetFunctionButtonState(PlayerVisualsPresetSlotFunctionButton.State state)
		{
		}
	}
}
