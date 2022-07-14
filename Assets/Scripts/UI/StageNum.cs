using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageNum : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI text;

	private void OnEnable()
	{
		text.text = $"STAGE {StageManager.currentStage + 1}";
	}
}
