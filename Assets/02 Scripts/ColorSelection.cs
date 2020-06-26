using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorSelection : MonoBehaviour
{
    public Transform ColorPickerObj;

    public ColorPickerUnityUI myPicker;

    public Transform rightHandController;

    void Start()
    {
        myPicker = ColorPickerObj.GetComponent<ColorPickerUnityUI>();
    }

    void Update()
    {
        Ray ray = new Ray(rightHandController.position, rightHandController.forward);
        RaycastHit hitInfo = new RaycastHit();

        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, 1 << 9))
        {
            Vector3 hitPosition = hitInfo.point - ColorPickerObj.position;


            if (OVRInput.GetDown(OVRInput.Button.Two))
            {
                if(myPicker != null)
                {
                    myPicker.OnPress(hitPosition);
                }
            }

            else if (myPicker != null)
            {
                myPicker.OnDrag(hitPosition);
            }
        }


        

    }
}
