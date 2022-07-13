using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
	public void UnActive(GameObject obj)
	{
		obj.SetActive(false);
	}
	public void Active(GameObject obj)
	{
		obj.SetActive(true);
	}
	public void TimerActive(GameObject obj)
	{
		StartCoroutine(TimerActiveCo(obj));
	}

	IEnumerator TimerActiveCo(GameObject obj)
	{
		obj.SetActive(false);
		yield return new WaitForSeconds(1f);
		obj.SetActive(true);
	}

	public void SceneMove(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
