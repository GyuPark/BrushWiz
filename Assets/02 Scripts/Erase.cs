using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 목표
1. 지우개가 가동된 상태에서 물체에 닿으면 그 물체를 지운다.
*/
public class Erase : MonoBehaviour
{
    bool isErasing;
    GameObject objectToErase;
    float absorbSpeed;

    void OnEnable()
    {
        objectToErase = null;
        absorbSpeed = 20f;
    }

    void Update()
    {
        EraseKey();
        EraseObject();
    }

    void OnTriggerEnter(Collider other)
    {
        //지우개가 가동된 상태에서 물체를 감지하면 그 물체를 objectToErase에 할당한다.
        if (isErasing)
        {
            objectToErase = other.gameObject;
        }
    }

    /// <summary>
    /// 지우개 가동 bool 조절 method
    /// </summary>
    void EraseKey()
    {
        isErasing = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
    }

    /// <summary>
    /// 물체를 지우는 메서드. objectToErase의 포지션을 지우개 중앙으로 점차 끌어오고, 스케일을 점차 줄인다.
    /// </summary>
    void EraseObject()
    {
        if (objectToErase != null)
        {
            //1. position을 지우게 중앙으로 끌고온다.
            objectToErase.transform.position = Vector3.Lerp(objectToErase.transform.position, gameObject.transform.position, Time.deltaTime * absorbSpeed);
            //2. scale을 줄인다
            objectToErase.transform.localScale = Vector3.Lerp(objectToErase.transform.localScale, Vector3.zero, Time.deltaTime * absorbSpeed);
            //3. 일정 거리 이상 가까워지면 Destroy한다.
            if (Vector3.Distance(objectToErase.transform.position, gameObject.transform.position) < 0.1f)
            {
                Destroy(objectToErase);
            }
        }
    }
}
