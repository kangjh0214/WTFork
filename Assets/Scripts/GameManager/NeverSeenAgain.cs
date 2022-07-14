using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverSeenAgain : MonoBehaviour
{
	private void Awake()
	{
		PlayerPrefs.SetInt("Seen", 1);
	}
}
