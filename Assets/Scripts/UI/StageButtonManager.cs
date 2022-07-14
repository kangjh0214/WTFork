using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageButtonManager : MonoBehaviour
{
	[SerializeField] private Sprite FoodStageImage;
	[SerializeField] private Sprite OpenStageImage;
    [SerializeField] private Sprite LockStageImage;

	[SerializeField] private GameObject[] buttons;

	private void Awake()
	{
		for (int i = 0; i <= PlayerPrefs.GetInt("OpenStage", 0); i++)
		{
			if (i == PlayerPrefs.GetInt("OpenStage", 0))
			{
				buttons[i].GetComponent<Image>().sprite = OpenStageImage;
				buttons[i].GetComponent<StageButton>().isLocked = false;
			}
			else
			{
				buttons[i].GetComponent<Image>().sprite = FoodStageImage;
				buttons[i].GetComponent<StageButton>().isLocked = false;
			}
		}
	}
}
