using TMPro;
using UnityEngine;

public class KeeperScoreStatistics : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _curStatisticesText;

	[SerializeField]
	private TMP_Text _bestStatisticesText;

	private int _curStatistices;

	private int _bestStatistices;

	private void Start()
	{
	}

	public void OnBallEnteredDeadZone()
	{
	}

	public void OnGoal()
	{
	}

	private void Update()
	{
	}
}
