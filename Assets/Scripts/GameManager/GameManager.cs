using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Player;

	public static GameManager instance;
	public UnityEvent onGameOver;
	public UnityEvent onGameClear;
	public UnityEvent onGameReady;
	public UnityEvent timerStop;
	public UnityEvent timerReset;

	private enum State { Ready, Playing, Over, Clear };
    private State state = State.Ready;

	private void Awake()
	{
		Time.timeScale = 1f;
		instance = this;
	}

	public void TimeStop()
	{
		timerStop.Invoke();
	}
	public void TimeReset()
	{
		timerReset.Invoke();
	}
	public void GameReady()
	{
		Debug.Log("GameReady");
		state = State.Ready;

		if (state == State.Ready) {
			onGameReady.Invoke();
			timerReset.Invoke();
		}
	}
	public void GameOver() 
	{
		Debug.Log("GameOver");
		state = State.Over;

		if (state == State.Over) {
			onGameOver.Invoke();
		}
	}
	public void GameClear()
	{
		Debug.Log("GameClear");
		state = State.Clear;

		if (state == State.Clear) {
			onGameClear.Invoke();
		}
	}
	public void GameDelay()
	{
		Invoke("GameReady", 1f);
	}
}
