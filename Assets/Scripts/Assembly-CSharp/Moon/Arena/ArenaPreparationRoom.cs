using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Moon.Hub;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaPreparationRoom : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTeleportAndOpenDoorRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaPreparationRoom _003C_003E4__this;

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
			public _003CTeleportAndOpenDoorRoutine_003Ed__8(int _003C_003E1__state)
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
		private DoorController _topDoor;

		[SerializeField]
		private DoorController _bottomDoor;

		[SerializeField]
		private Transform _teleportPoint;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void DisableDoors()
		{
		}

		private void ToggleInDoor(bool open, bool immediate)
		{
		}

		public void TeleportPlayerToRoom()
		{
		}

		[IteratorStateMachine(typeof(_003CTeleportAndOpenDoorRoutine_003Ed__8))]
		private IEnumerator TeleportAndOpenDoorRoutine(Transform thisPlace, Transform otherPlace)
		{
			return null;
		}

		private void MoveToOtherPlace(Transform otherPlace)
		{
		}
	}
}
