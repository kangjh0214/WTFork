using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageButtonManager : MonoBehaviour
{
    [SerializeField] private Sprite OpenStageImage;
    [SerializeField] private Sprite LockStageImage;

	private GameObject[] buttons;

	private void Awake()
	{
		buttons = GameObject.FindGameObjectsWithTag("Buttons");
		for (int i = 0; i <= PlayerPrefs.GetInt("OpenStage"); i++)
		{
			buttons[i].GetComponent<Image>().sprite = OpenStageImage;
			buttons[i].GetComponent<StageButton>().isLocked = false;
		}
	}
}
