using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField]
    GameObject _target;

	private void Update()
	{
		transform.position = new Vector3(_target.transform.position.x, _target.transform.position.y);
	}
}
