using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageButton : MonoBehaviour
{
    private bool _isLocked = true;
    
    public bool isLocked
	{
        get { return _isLocked; }
        set { _isLocked = value; }
	}

    public void ChangeScene(int stageNum)
	{
        if (!_isLocked)
		{
            StageManager.currentStage = stageNum;
            SceneManager.LoadScene("Play");
		}
	}
}
