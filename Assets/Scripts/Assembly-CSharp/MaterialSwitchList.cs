using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MaterialSwitchList : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSwitchMaterials_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaterialSwitchList _003C_003E4__this;

		public float duration;

		private int _003CmaterialCount_003E5__2;

		private float _003Cinterval_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CSwitchMaterials_003Ed__4(int _003C_003E1__state)
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

	public List<Material> materials;

	public float switchDuration;

	private Renderer objectRenderer;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CSwitchMaterials_003Ed__4))]
	private IEnumerator SwitchMaterials(float duration)
	{
		return null;
	}
}
