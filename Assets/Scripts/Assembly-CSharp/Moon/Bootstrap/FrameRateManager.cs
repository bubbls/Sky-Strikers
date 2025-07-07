using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.LowLevel;

namespace Moon.Bootstrap
{
	public class FrameRateManager : MonoBehaviour
	{
		private enum AddMode
		{
			FirstChild = 0,
			LastChild = 1,
			Before = 2,
			After = 3
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct FillFrameBeforeEarlyUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct FillFrameBeforeUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct FillFrameAfterUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct FrameBeforeUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct FrameEndUpdate
		{
		}

		public bool Enable;

		private float _fillFrameBeforeUpdateTime;

		private float _frameBeforeUpdateTime;

		private float _earlyUpdateTime;

		private const float _earlyUpdateOffset = 0.002f;

		private PlayerLoopSystem.UpdateFunction _networkUpdateDelegate;

		[SerializeField]
		private uint _sampleInterval;

		private uint _sampleCount;

		private float _lastSampleFPS;

		private float _totalSampleFPS;

		private TextMeshProUGUI _textMesh;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void InjectUpdateForFPS()
		{
		}

		private void RevertUpdateForFPS()
		{
		}

		private void InjectUpdateForFill()
		{
		}

		private void RevertUpdateForFill()
		{
		}

		private static bool AddToPlayerLoop(ref PlayerLoopSystem parentSystem, Type referenceSystemType, AddMode addMode, Type ownerType, PlayerLoopSystem.UpdateFunction updateDelegate)
		{
			return false;
		}

		private static bool RemoveFromPlayerLoop(ref PlayerLoopSystem parentSystem, Type type)
		{
			return false;
		}

		private static void InsertSystem(ref PlayerLoopSystem[] systems, int position, Type ownerType, PlayerLoopSystem.UpdateFunction updateDelegate)
		{
		}

		private void InvokeBeforeUpdateForFill()
		{
		}

		private void InvokeAfterUpdateForFill()
		{
		}

		private void InvokeFrameBeginUpdate()
		{
		}

		private void InvokeFrameEndUpdate()
		{
		}

		private void OutputFPSScore()
		{
		}
	}
}
