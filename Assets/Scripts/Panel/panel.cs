using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel : MonoBehaviour
{
    public Transform logo;
    public Transform btn;

    private void Start()
    {
        
    }
    public void BtnStart(string tagName)
    {
        StartCoroutine("stagebtn", tagName);
        StartCoroutine("Pan", tagName);
    }



    IEnumerator stagebtn(string Tag)
    {
        logo.transform.position = new Vector3(0, -1000, 0);
        btn.transform.position = new Vector3(0, -1000, 0);


        GameObject target = GameObject.FindGameObjectWithTag(Tag);
        Vector3 Pos = new Vector3(0, 0, 0);

        while (true)
        {
            target.transform.localPosition = Vector3.Lerp(target.transform.localPosition, Vector3.zero, 0.1f);
            yield return new WaitForSeconds(0.025f);
        }
    }




    IEnumerator Pan(string tag)
    {
        GameObject target = GameObject.FindGameObjectWithTag(tag);
        Vector3 targetPos = new Vector3(0, 0, 0);
        
        while (true)
        {
            target.transform.localPosition = Vector3.Lerp(target.transform.localPosition, Vector3.zero, 0.1f);
            yield return new WaitForSeconds(0.025f);
            if(target.transform.localPosition == Vector3.zero)
            {
                break;
            }
        }
    }
}
