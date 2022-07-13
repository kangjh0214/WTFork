using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocationer : MonoBehaviour
{
    private GameObject target;

	private void Update()
	{
		target = GameObject.Find("Food");

		Vector2 dir = target.transform.position - transform.position;

		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.Euler(0, 0, angle);
	}
}
