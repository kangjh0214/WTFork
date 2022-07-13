using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string nextScene;
    [SerializeField] private float SceneChangeTime;
	private float timer;

	private void Awake()
	{
		timer = SceneChangeTime;
	}

	private void Update()
	{
		if (timer > 0) timer -= Time.deltaTime;
		else if (timer <= 0) SceneManager.LoadScene(nextScene);
	}
}
