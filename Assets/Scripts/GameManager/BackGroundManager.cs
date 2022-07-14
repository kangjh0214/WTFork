using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundManager : MonoBehaviour
{
    [SerializeField] private GameObject Player;

	private void Update()
	{
		transform.position = new Vector3(Player.transform.position.x / 1.1f, Player.transform.position.y / 1.2f);
	}
}
