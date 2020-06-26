using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Instantiate
Draw → Animate
순으로 작동한다
*/
public class ButterflyFactory : MonoBehaviour
{
    enum State
    {
        INSTANTIATE,
        DRAW,
    }

    State state = State.INSTANTIATE;

    public GameObject butterflyFactory;
    GameObject butterfly;

    public void Execute()
    {
        switch (state)
        {
            case State.INSTANTIATE:
                //Instantiate butterfly gameobj
                butterfly = Instantiate(butterflyFactory);
                //Locate it in front of the main cam
                butterfly.transform.position = Camera.main.transform.position + new Vector3(0, 0, .5f);
                butterfly.transform.SetParent(GameObject.Find("Drawing").transform, true);
                //state transition
                state = State.DRAW;
                break;
            case State.DRAW:
                //If the user has finished painting,
                //disable SkinnedMeshRenderer
                butterfly.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
                //bring it to life by enabling its animation component
                butterfly.GetComponent<Animation>().enabled = true;
                //turn every rigidbody and triggerObj components in its children off
                Rigidbody[] rb = butterfly.GetComponentsInChildren<Rigidbody>();
                TriggerObj[] to = butterfly.GetComponentsInChildren<TriggerObj>();
                foreach (var item in rb)
                {
                    item.detectCollisions = false;
                    //item.gameObject.GetComponent<TriggerObj>().enabled = false;
                    item.gameObject.GetComponent<MeshRenderer>().enabled = false;
                }
                foreach (var item in to)
                {
                    item.enabled = false;
                }

                state = State.INSTANTIATE;
                break;
            default:
                break;
        }
    }
}
