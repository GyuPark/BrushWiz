using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftController : MonoBehaviour
{


    public GameObject laserPoint;

    public float laserDis;

    public Transform rightHandController;
    public Transform leftHandController;
    public bool isStart;


    void Update()
    {
        LaserOnOff();
    }


    void LaserOnOff()
    {

        if (Vector3.Distance(leftHandController.position, rightHandController.position) < laserDis)
        {

            laserPoint.SetActive(true);
        }
        else
        {

            if (isStart)
            {
                laserPoint.SetActive(true);
            }
            else
            {
                laserPoint.SetActive(false);
            }

           
        }
    }


}
