using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{

    public void BtnStart(string tagName)
    {
        StartCoroutine("Pan", tagName);
    }

    IEnumerator Pan(string tag)
    {
        GameObject target = GameObject.FindGameObjectWithTag(tag);
        Vector3 targetPos = new Vector3(0, 0, 0);

        while (true)
        {
            target.transform.localPosition = Vector3.Lerp(target.transform.localPosition, new Vector3(1100, 0, 0), 0.1f);
            yield return new WaitForSeconds(0.025f);
        }
    }
}
