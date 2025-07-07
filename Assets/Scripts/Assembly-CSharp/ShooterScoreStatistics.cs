using TMPro;
using UnityEngine;

public class ShooterScoreStatistics : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _curStatisticesText;

	[SerializeField]
	private TMP_Text _timerText;

	[SerializeField]
	private TMP_Text _bestStatisticesText;

	private int _curStatistices;

	private int _bestStatistices;

	private float _bestTimer;

	private bool _start;

	private float _timer;

	private void Start()
	{
	}

	public void OnGoal(int score)
	{
	}

	public void OnBallEnteredDeadZone()
	{
	}

	private void Update()
	{
	}
}
