using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float startTime;
	[SerializeField] private float startTurnRedTime;
    [SerializeField] private TextMeshProUGUI timerText;
	[SerializeField] private TextMeshProUGUI clearTimeText;
	[SerializeField] private TextMeshProUGUI bestTimeText;
	private float currentTime;
    private bool isTimerOn = false;
	private float _clearTime;

	public float clearTime { get { return _clearTime; } }

	private void Awake()
	{
		currentTime = startTime;
		timerText.text = $"{(int)currentTime}";
		timerText.gameObject.SetActive(false);
	}

	private void Update()
	{
		if (currentTime <= startTurnRedTime) timerText.color = new Color(255f / 255f, currentTime / startTurnRedTime, currentTime / startTurnRedTime);
		else timerText.color = Color.white;
		if (isTimerOn) {
			currentTime -= Time.deltaTime;
			timerText.text = $"{(int)currentTime + 1}"; 
		}
		if (currentTime <= 0)
		{
			timerText.text = $"{0}";
			GameManager.instance.TimeStop();
			GameManager.instance.GameOver();
		}
	}

	public void StartTimer()
	{
		currentTime = startTime;
        isTimerOn = true;
	}

	public void StopTimer()
	{
		isTimerOn = false;
		_clearTime = startTime - currentTime;
		currentTime = startTime;
	}

	public void TimerReset()
	{
		timerText.text = $"{(int)currentTime}";
	}

	public void ClearTime()
	{
		clearTimeText.text = $"ClearTime : {clearTime.ToString("F2")}s";
		if (PlayerPrefs.GetFloat($"ClearTime{StageManager.currentStage}", 0) > _clearTime || 
			PlayerPrefs.GetFloat($"ClearTime{StageManager.currentStage}") == 0)
		{
			PlayerPrefs.SetFloat($"ClearTime{StageManager.currentStage}", _clearTime);
			clearTimeText.color = new Color(255f / 255f, 255f / 255f, 0f / 255f);
		}
		else clearTimeText.color = new Color(177f / 255f, 255f / 255f, 78f / 255f);
		bestTimeText.text = $"BestTime : {PlayerPrefs.GetFloat($"ClearTime{StageManager.currentStage}", 0).ToString("F2")}s";
	}
}
