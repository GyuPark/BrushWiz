using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Brush가 가지는 정보
//1. 굵기(diameter) : right joystick 좌우로 조절 가능 
//2. 기울기 : right joystick 상하로 조절 가능

public class BrushInfo : MonoBehaviour
{
    float scaleFactor = 1f;
    float xRot = 45f;
    float scaleSpeed = 30f;
    float rotSpeed = 50f;

    Vector3 initialScale;

    private void Start()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        AdjustThickness();
        AdjustAngle();
    }

    void AdjustThickness()
    {
        scaleFactor += OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch).x * scaleSpeed * Time.deltaTime;
        scaleFactor = Mathf.Clamp(scaleFactor, 1f, 20f);
        transform.localScale = initialScale * scaleFactor;
    }

    void AdjustAngle()
    {
        xRot += OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch).y * rotSpeed * Time.deltaTime;
        xRot = Mathf.Clamp(xRot, -45f, 75f);
        transform.localEulerAngles = new Vector3(xRot, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
