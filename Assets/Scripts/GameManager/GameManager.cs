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

	private enum State { Ready, Playing, Over, Clear };
    private State state = State.Ready;

	private void Awake()
	{
		Time.timeScale = 1f;
		instance = this;
	}

	public void GameReady()
	{
		state = State.Ready;

		if (state == State.Ready) {
			onGameReady.Invoke();
		}
	}
	public void GameOver() 
	{
		state = State.Over;

		if (state == State.Over) {
			onGameOver.Invoke();
		}
	}
	public void GameClear()
	{
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
