using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Commands;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[NetworkBehaviourWeaved(31)]
	public class MAmmoBox : NetworkBehaviour, ICommandExecutor
	{
		[StructLayout((LayoutKind)2, Size = 4)]
		[NetworkStructWeaved(1)]
		public struct Status : INetworkStruct
		{
			[FieldOffset(0)]
			public int BulletAmount;
		}

		[CompilerGenerated]
		private sealed class _003CReloadingFxRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int newAmount;

			public Weapons.Specific specific;

			public int oldAmount;

			public MAmmoBox _003C_003E4__this;

			private bool _003CisFull_003E5__2;

			private int _003Ccount_003E5__3;

			private WaitForSeconds _003Cw_003E5__4;

			private int _003Ci_003E5__5;

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
			public _003CReloadingFxRoutine_003Ed__20(int _003C_003E1__state)
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

		[DefaultForProperty("WeaponStatus", 0, 31)]
		private SerializableDictionary<WeaponType, Status> _WeaponStatus;

		[SerializeField]
		private SoundInfo _sfxCharge;

		[SerializeField]
		private SoundInfo _sfxChargeFull;

		private static Changed<MAmmoBox> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MAmmoBox> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MAmmoBox> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 31)]
		[Capacity(5)]
		[Networked(OnChanged = "OnWeaponStatusChanged")]
		private NetworkDictionary<WeaponType, Status> WeaponStatus => default(NetworkDictionary<WeaponType, Status>);

		public WeaponType ActiveWeaponAmmo { get; private set; }

		public event Action<WeaponType, Status> OnStatusChanged
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

		public override void Spawned()
		{
		}

		public void SetActiveWeapon(WeaponType weaponType)
		{
		}

		[Preserve]
		private static void OnWeaponStatusChanged(Changed<MAmmoBox> changed)
		{
		}

		private void RaiseWeaponStatusChanged()
		{
		}

		public void NotifyWeaponStatusChanged()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_PlayReloadingFx(WeaponType weaponType, int oldAmount, int statusBulletAmount)
		{
		}

		private void PlayReloadingFx(WeaponType weaponType, int oldAmount, int newAmount)
		{
		}

		[IteratorStateMachine(typeof(_003CReloadingFxRoutine_003Ed__20))]
		private IEnumerator ReloadingFxRoutine(int oldAmount, int newAmount, Weapons.Specific specific)
		{
			return null;
		}

		public bool ChangeAmmo(WeaponType weaponType, int amount, ChangeAmmo.ChangeType changeType, out int diff)
		{
			diff = default(int);
			return false;
		}

		private void RegisterWeapons(WeaponType weaponType)
		{
		}

		public bool TryUseOneBullet(WeaponType weaponType, out bool lastBullet)
		{
			lastBullet = default(bool);
			return false;
		}

		public bool HasBullets(WeaponType weaponType, out bool lastBullet)
		{
			lastBullet = default(bool);
			return false;
		}

		public bool TryGetWeaponStatus(WeaponType weaponType, out Status status)
		{
			status = default(Status);
			return false;
		}

		public int GetBulletCount(WeaponType weaponType)
		{
			return 0;
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 2)]
		[Preserve]
		protected unsafe static void Rpc_PlayReloadingFx_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
