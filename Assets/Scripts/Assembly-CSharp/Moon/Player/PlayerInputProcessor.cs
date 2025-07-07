using System;
using Moon.MultiPlay;

namespace Moon.Player
{
	[Serializable]
	public class PlayerInputProcessor
	{
		private PlayerInputData _latestPlayerInputData;

		private MXRInputData _latestMxrInputData;

		private MXRInputAction _cachedLeftLocalMxrInputData;

		private MXRInputAction _cachedRightLocalMxrInputData;

		private MXRInputAction _tempInputData;

		public PlayerInputData LatestPlayerInputData => default(PlayerInputData);

		public MXRInputData LatestMxrInputData => default(MXRInputData);

		public void ProcessInput(PlayerInputData inputData)
		{
		}

		public void ProcessInput(MXRInputData inputData)
		{
		}

		private void ProcessInput(in MXRInputAction latestInputData, ref MXRInputAction cachedInputData, out MXRInputAction targetInputAction)
		{
			targetInputAction = default(MXRInputAction);
		}
	}
}
