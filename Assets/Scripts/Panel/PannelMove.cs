using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelMove : MonoBehaviour
{


    GameObject target;

    private void Start()
    {
        
    }
    public void ObjSelect(GameObject obj)
    {
        target = obj; 
    }
    public void MoveTo(float ToPos)
    {
        StopAllCoroutines();
        StartCoroutine(MoveToCo(target, new Vector2(ToPos, 0)));
    }
    IEnumerator MoveToCo(GameObject obj, Vector2 ToPos)
    {
        while (true)
        {
            obj.transform.localPosition = Vector2.Lerp(obj.transform.localPosition, ToPos, 0.1f);

            yield return new WaitForSeconds(0.025f);
        }
    }

    public void MoveToX(float ToPos)
    {
        StopAllCoroutines();
        StartCoroutine(MoveToCo(target, new Vector2(0, ToPos)));
    }
}
