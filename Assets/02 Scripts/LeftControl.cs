using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftControl : MonoBehaviour
{
    // Start is called before the first frame update

     //기준
    public GameObject ancher;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {



            transform.RotateAround(ancher.transform.position, transform.up, 180f);


            //transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

            // transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            //  transform.Rotate(ancher.transform.getr, 180f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.transform.gameObject.layer == LayerMask.NameToLayer("Laser")){

        //    print("들어왔나~");

        //    other.gameObject.SetActive(true);

        //}


        if (other.transform.gameObject.CompareTag("Laser"))
        {

            print("들어왔나~");

            other.gameObject.SetActive(true);

        }


    }

    private void OnTriggerExit(Collider other)
    {

        if (other.transform.gameObject.CompareTag("Laser"))
        {

            print("나갔나~");

            other.gameObject.SetActive(false);

        }

    }
}
