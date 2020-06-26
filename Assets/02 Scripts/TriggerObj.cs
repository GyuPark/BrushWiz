using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Animation 켜기 전까지 TriggerObj가 감지하는 오브젝트들은 모두 DrawArea(parent)의 child가 된다.
*/
public class TriggerObj : MonoBehaviour
{
    public List<GameObject> objList = new List<GameObject>();

    private void OnTriggerStay(Collider other)
    {
        if (objList.Count == 0)
        {
            objList.Add(other.gameObject);
            other.transform.SetParent(transform.parent, true);
            return;
        }
        //검사기
        foreach (var item in objList)
        {
            if (item.transform == other.transform)
            {
                return;
            }
            if (other.transform.name.Contains("Img") || other.transform.name.Contains("Ani"))
            {
                return;
            }
        }
        //objList에 other.gameObject가 없다면, other.gameObject를 objList에 추가한다.
        objList.Add(other.gameObject);
        //other.gameObject를 DrawArea의 child로 넣는다.
        other.transform.SetParent(transform.parent, true);
    }
}
