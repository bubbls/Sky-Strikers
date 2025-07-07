using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TransparentBackgroundScreenshotRecorder : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCaptureFrame_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TransparentBackgroundScreenshotRecorder _003C_003E4__this;

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
		public _003CCaptureFrame_003Ed__14(int _003C_003E1__state)
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

	[Tooltip("A folder will be created with this base name in your project root")]
	public string folderBaseName;

	[Tooltip("How many frames should be captured per second of game time")]
	public int frameRate;

	[Tooltip("How many frames should be captured before quitting")]
	public int framesToCapture;

	private string folderName;

	private Camera renderCamera;

	private int renderFrame;

	private float originalTimescaleTime;

	private bool done;

	private int width;

	private int height;

	private RenderTexture renderTexture;

	private Texture2D outputTexture;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CCaptureFrame_003Ed__14))]
	private IEnumerator CaptureFrame()
	{
		return null;
	}

	private void CacheAndInitialiseFields()
	{
	}

	private void CreateNewFolderForScreenshots()
	{
	}

	public void RenderTextureToPNG()
	{
	}

	private void SavePng()
	{
	}
}
