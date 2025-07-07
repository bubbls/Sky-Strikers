using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using DG.Tweening;
using DP.Takeaway.Sound;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.GameActivity
{
	public class PipeController : SingleMonoBehaviour<PipeController, InSceneSingleMonoBehaviourSettings>
	{
		public enum PipeType
		{
			SuckerToResearch = 0,
			Research = 1
		}

		[Serializable]
		private class Pipe
		{
			[SerializeField]
			private MeshRenderer _pipeRenderer;

			[SerializeField]
			private float _min;

			[SerializeField]
			private float _max;

			[SerializeField]
			private float _width;

			[SerializeField]
			private SoundInfo _sfxAtEnd;

			private Material _material;

			private float _amount;

			private float _widthAmount;

			public void Initialize()
			{
			}

			public void StartFillEnergy(Sequence sequence, float fillTime, Transform sfxPivot)
			{
			}

			private void UpdateVisual()
			{
			}
		}

		public static readonly int ParamLevelingWidth;

		public static readonly int ParamLevelingMove;

		public static readonly int ParamLevelingColorSoft;

		private const float FlagResearchMachinePipeColorSoft = 0.14f;

		[SerializeField]
		private float _fillTime;

		[SerializeField]
		private Transform _pivotLeaderboard;

		[SerializeField]
		private Transform _pivotFlagMachine;

		[SerializeField]
		private List<Pipe> _pipeFromSuckerToResearch;

		[SerializeField]
		private List<Pipe> _pipeResearch;

		private Sequence _sequence0;

		private Sequence _sequence1;

		[SerializeField]
		private MeshRenderer _researchPipeRenderer;

		[SerializeField]
		private List<float> _researchProgressValues;

		private Material _researchPipeMaterial;

		private int _researchProgressIndex;

		private Tween _researchTween;

		private Tween _colorSoftTween;

		private float _targetResearchColorSoft;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void UpdateResearchProgressVisual(bool immediate)
		{
		}

		[Preserve]
		public static void FillEnergy(PipeType pipeType)
		{
		}

		public static void FillEnergy(PipeType pipeType, Action complete)
		{
		}

		private void FillEnergyInternal(PipeType pipeType, Action complete)
		{
		}

		public static void FillResearchProgress(int researchProgress, bool readyToUpgrade, bool hasColorSoft)
		{
		}

		private void FillResearchProgressInternal(int researchProgress, bool readyToUpgrade, bool hasColorSoft)
		{
		}
	}
}
