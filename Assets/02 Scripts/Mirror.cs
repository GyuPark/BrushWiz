using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Mirror 기능
1. Selection Tool을 사용해 Enable 할 수 있다.
2. Enable 시 position은 right 컨트롤러의 child로써 위치한다.
3. Trigger을 release 해야만 작동하기 시작한다.
4. Enable된 상태에서 Selection Tool의 버튼을 다시 클릭하면 Disable된다.
*/
public class Mirror : MonoBehaviour
{

    #region Variables
    public Transform parent;

    static bool isMirroring = false;
    public static bool Mirroring
    {
        get { return isMirroring; }
        set { isMirroring = value; }
    }

    static Vector3 mirrorPos;
    public static Vector3 MirrorPos
    {
        get { return mirrorPos; }
        set { mirrorPos = value; }
    }

    static Vector3 mirrorRot;
    public static Vector3 MirrorRot
    {
        get { return mirrorRot; }
        set { mirrorRot = value; }
    }

    static Vector2 mirrorEquation;
    public static Vector2 MirrorEquation
    {
        get { return mirrorEquation; }
        set { mirrorEquation = value; }
    }

    #endregion

    #region Main Methods

    void OnEnable()
    {
        Init();
    }

    void Update()
    {
        
        FixXANDZRot();
        
        if (MirrorActive())
        {
            MirrorPos = transform.position;
            MirrorRot = transform.eulerAngles;
            MirrorEquation = CalculateReflection.GetLinearEquation(MirrorRot.y, MirrorPos.x, MirrorPos.z);
            print("MirrorRot.y = "+MirrorRot.y);
            print("MirrorPos.x = " + MirrorPos.x);
            print("MirrorPos.z = " + MirrorPos.z);
            print("MirrorEquation = " + MirrorEquation);
        }
    }

    void OnDisable()
    {
        Mirroring = false;
    }
    #endregion

    #region Helper Methods
    /// <summary>
    /// Initialise upon enabling
    /// </summary>
    void Init()
    {
        transform.SetParent(parent);
        transform.localPosition = transform.parent.position;
    }

    bool MirrorActive()
    {
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            if (!Mirroring)
            {
                Mirroring = true;
            }
            transform.parent = null;
        }

        return Mirroring;
    }

    void FixXANDZRot()
    {
        transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
    }
    #endregion

}
