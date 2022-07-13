using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static int currentStage;
    private int openStages;

	private void Awake()
	{
		openStages = PlayerPrefs.GetInt("OpenStage", 0);
	}

	public void StageClear()
	{
	}
}
