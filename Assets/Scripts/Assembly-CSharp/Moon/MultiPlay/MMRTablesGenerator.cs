using JetBrains.Annotations;
using Moon.PlayerProfile;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.MultiPlay
{
	[CreateAssetMenu(fileName = "MMRTablesGenerator", menuName = "Chamber8/Multiplay/Create MMRTablesGenerator")]
	public class MMRTablesGenerator : ScriptableObject
	{
		[Header("MMR Scaling Table")]
		[SerializeField]
		private MMRScalingTable _scalingTable;

		[SerializeField]
		private string _scalingTableJsonToImport;

		[SerializeField]
		private int _testMMR;

		[SerializeField]
		private MatchResult _testMatchResult;

		[SerializeField]
		[Header("MMR Levels Table")]
		private MMRLevelsTable _levelsTable;

		[SerializeField]
		private string _levelsTableJsonToImport;

		[SerializeField]
		[Header("MMR Groups Info Table")]
		private MMRGroupsInfoTable _groupsInfoTable;

		[SerializeField]
		private string _groupsInfoTableJsonToImport;

		[SerializeField]
		private int[] _playerMmrScores;

		[Header("Simulate Rank Preventing Losing Group")]
		[SerializeField]
		private int _currentMMR;

		[SerializeField]
		private int _newMMR;

		public MMRScalingTable ScalingTable => null;

		public MMRLevelsTable LevelsTable => null;

		public MMRGroupsInfoTable GroupsInfoTable => null;

		[Button("Copy Scaling Table JSON", EButtonEnableMode.Always)]
		[UsedImplicitly]
		public void CopyScalingTableJson()
		{
		}

		[Button("Import Scaling Table JSON", EButtonEnableMode.Always)]
		[UsedImplicitly]
		public void ImportJson()
		{
		}

		[Button("Test Scaling", EButtonEnableMode.Always)]
		[UsedImplicitly]
		public void TestScaling()
		{
		}

		[UsedImplicitly]
		[Button("Copy Levels Table JSON", EButtonEnableMode.Always)]
		public void CopyLevelsTableJson()
		{
		}

		private void CopyStringToClipboard(string json)
		{
		}

		[UsedImplicitly]
		[Button("Import Levels Table JSON", EButtonEnableMode.Always)]
		public void ImportLevelsTableJson()
		{
		}

		[Button("Balance Team Simulation", EButtonEnableMode.Always)]
		[UsedImplicitly]
		public void BalanceTeam()
		{
		}

		[Button("Copy Groups Info Table JSON", EButtonEnableMode.Always)]
		[UsedImplicitly]
		public void CopyGroupsInfoTableJson()
		{
		}

		[Button("Import Groups Info Table JSON", EButtonEnableMode.Always)]
		[UsedImplicitly]
		public void ImportGroupsInfoJson()
		{
		}

		[Button("Simulate Rank Preventing Losing Group", EButtonEnableMode.Always)]
		[UsedImplicitly]
		public void SimulateRankPreventingLosingGroup()
		{
		}
	}
}
