using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//목표:
//0. 초기값 설정 : midPoint 위치, 거리, 각도(midPoint Normal (world) - Vector3.forward)
//1. 초기값과 비교해 실시간으로 move, rotate on Y, scale(범위 有) 한다
public class ControlDrawing : MonoBehaviour
{
    bool isControlling;
    bool initializble;
    bool startControlling;

    Vector3 initialPos; //초기 위치
    Vector3 initialMidPointPos; //초기 중간점 위치

    Vector3 initialScale; //초기 사이즈
    float initialDistance; //초기 거리

    Vector3 initialAngleVector;
    Vector3 initialRotation;

    public Transform leftController, rightController;

    //레이저 포인트 
    public GameObject laserPoint;
    public float laserDis;

    void Start()
    {
        startControlling = true;
        isControlling = false;
        initializble = false;
    }

    void Update()
    {
        ControlKey();
        Init();
        ControlScale();
        ControlPosition();
        ControlYRotation();
        LaserOnOff();
    }

    /// <summary>
    /// Key값 받아오는 함수
    /// </summary>
    void ControlKey()
    {
        if(OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch) && OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        //if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) == 1f && OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) == 1f) //grab 동시에 누르면?
        {
            //컨트롤 시작하는 거라면?
            if (startControlling)
            {
                //초기값 설정 키 = true - "Init()에서 다시 false됨"
                initializble = true;
                startControlling = false;
            }

            //컨트롤 중이니까
            isControlling = true;
        }
        else
        {
            isControlling = false;
            startControlling = true;
        }
    }

    /// <summary>
    /// 초기값 설정 함수 : control 시작 시점인 오직 한 번만 실행된다!
    /// </summary>
    void Init()
    {
        if (initializble)
        {
            //초기화 :
            //위치
            initialPos = transform.position;
            //초기 중간값 위치
            initialMidPointPos = (leftController.transform.position + rightController.transform.position) / 2;

            //거리
            initialDistance = Vector3.Distance(leftController.position, rightController.position);
            //초기 크기 변수에 저장
            initialScale = transform.localScale;

            //각도
            initialAngleVector = rightController.position - leftController.position;
            initialRotation = transform.eulerAngles;

            //initializble 다시 false로!
            initializble = false;
        }
    }

    /// <summary>
    /// Scale 컨트롤
    /// </summary>
    void ControlScale()
    {
        if (isControlling)
        {
            float currentDistance = Vector3.Distance(leftController.position, rightController.position);
            float scaleFactor = currentDistance / initialDistance;
            Vector3 newScale = scaleFactor * initialScale;
            transform.localScale = new Vector3(newScale.x, newScale.y, newScale.z);
        }
    }

    /// <summary>
    /// position 컨트롤 
    /// </summary>
    void ControlPosition()
    {
        if (isControlling)
        {
            Vector3 currentMidPoint = (leftController.transform.position + rightController.transform.position) / 2;
            Vector3 displacement = currentMidPoint - initialMidPointPos;
            transform.position = initialPos + displacement;
        }
    }

    /// <summary>
    /// y-rotation 컨트롤
    /// </summary>
    void ControlYRotation()
    {
        if (isControlling)
        {
            Vector3 currentMidPoint = (leftController.transform.position + rightController.transform.position) / 2;
            Vector3 currentAngleVector = rightController.position - leftController.position;
            float yAngleDisplacement = initialAngleVector.z - currentAngleVector.z;
            transform.eulerAngles = initialRotation + new Vector3(0, yAngleDisplacement * 300, 0);

            //learn to rotate an object about an arbitrary point or an axis... later!
        }
    }

    void LaserOnOff()
    {

        if (Vector3.Distance(leftController.position, rightController.position) < laserDis)
        {

            laserPoint.SetActive(true);
        }
        else
        {

            laserPoint.SetActive(false);
        }
    }

}
