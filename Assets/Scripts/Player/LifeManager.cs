using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
	[SerializeField] private GameObject diyingEffect;
	[SerializeField] private GameObject clearEffect;
	[SerializeField] private GameObject reStartButton;
    private PlayerController myController;
    private Rigidbody2D myRigid;
	private bool gameEnd = false; //게임 종료

	private void Awake() //시작시 포크 정지
	{
		gameEnd = false;
		myController = GetComponent<PlayerController>();
		myRigid = GetComponent<Rigidbody2D>();
		GameReady();
	}

	private void OnTriggerEnter2D(Collider2D collision) //충돌시 포크 정지
	{
		Invoke("Stop", 0.05f);
		if (collision.gameObject == GameObject.Find("Food") && !gameEnd) {
			clearEffect.SetActive(false);
			clearEffect.transform.position = transform.position;
			clearEffect.SetActive(true);
			gameEnd = true;
			Invoke("GameClear", 1f); 
		}
		else if (!gameEnd) GameManager.instance.GameOver();
	}

	private void Stop()
	{
		myController.enabled = false;
		myRigid.gravityScale = 0f;
		myRigid.velocity = Vector2.zero;
		myRigid.angularVelocity = 0f;
	}

	public void GameReady()
	{
		gameObject.SetActive(true);
		gameEnd = false;
		Stop();
		transform.position = Vector2.zero;
		transform.rotation = Quaternion.Euler(0, 0, -40);
	}

	public void GameClear()
	{
		GameManager.instance.GameClear();
		gameEnd = true;
	}

	public void GameOver()
	{
		diyingEffect.SetActive(false);
		diyingEffect.transform.position = transform.position;
		diyingEffect.SetActive(true);
		gameEnd = true;
	}

	public void GameStart() //게임 시작 함수
	{
		myController.enabled = true;
	}
}
