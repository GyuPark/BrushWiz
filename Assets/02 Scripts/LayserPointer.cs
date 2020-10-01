using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayserPointer : MonoBehaviour
{
    private LineRenderer layser;        // 레이저

    private GameObject currentObject;   // 가장 최근에 충돌한 객체를 저장하기 위한 객체

    //기능툴
    public GameObject brush;
    public GameObject eraser;
    public GameObject boxbrush;
    public GameObject triangleBrush;
    public GameObject holoBrush;
    public GameObject wireFrameBrush;
    public GameObject snapShot;
    public GameObject mirror;

    //기능툴Img
    public GameObject brushImg;
    public GameObject eraserImg;
    public GameObject boxbrushImg;
    public GameObject bgImg;
    public GameObject triangleBrushImg;
    public GameObject holoBrushImg;
    public GameObject wireFrameBrushImg;
    public GameObject snapShotImg;
    public GameObject saveMeshImg;
    public GameObject butterflyImg;
    public GameObject mirrorImg;

    //기능툴 애니메이션
    public GameObject brushAni;
    public GameObject holoBrushAni;
    public GameObject eraserAni;
    public GameObject bgBoxAni;
    public GameObject boxbrushAni;
    public GameObject triangleBrushAni;
    public GameObject wireFrameBrushAni;
    public GameObject snapShotAni;
    public GameObject saveMeshAni;
    public GameObject butterflyAni;
    public GameObject mirrorAni;


    //BackGroundUi
    public GameObject bg_space;
    public GameObject bg_sea;
    public GameObject bg_earth;
    public GameObject bg_night;
    public GameObject bg_back;

    //배경 처리
    public Material spaceMat;
    public Material seaMat;
    public Material earthMat;
    public Material nightMat;

    //컬러피커
    public Transform ColorPickerObj;
    public ColorPickerUnityUI myPicker;
    public Transform rightHandController;

    //오브젝트 저장
    public GameObject saveProject;

    //백그라운드 선택인지 확인
    bool isBg;


    //나비 코드
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






    public float raycastDistance = 100f; // 레이저 포인터 감지 거리

    // Start is called before the first frame update
    void Start()
    {
        // 스크립트가 포함된 객체에 라인 렌더러라는 컴포넌트를 넣고있다.
        layser = this.gameObject.AddComponent<LineRenderer>();

        

        // 라인이 가지개될 색상 표현
        Material material = new Material(Shader.Find("Standard"));
        material.color = new Color(0, 195, 255, 0.5f);
        layser.material = material;
        // 레이저의 꼭지점은 2개가 필요 더 많이 넣으면 곡선도 표현 할 수 있다.
        layser.positionCount = 2;
        // 레이저 굵기 표현
        layser.startWidth = 0.01f;
        layser.endWidth = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {

        //ColorPicker();
        LaserPlaying();

        if (Input.GetKeyDown(KeyCode.P))
        {
            mirror.SetActive(true);
        }

    }

    private void LateUpdate()
    {
        // 버튼을 누를 경우        
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            layser.material.color = new Color(255, 255, 255, 0.5f);
        }

        // 버튼을 뗄 경우          
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            layser.material.color = new Color(0, 195, 255, 0.5f);
        }
    }


    void LaserPlaying()
    {


        layser.SetPosition(0, rightHandController.position); // 첫번째 시작점 위치
                                                             // 업데이트에 넣어 줌으로써, 플레이어가 이동하면 이동을 따라가게 된다.
                                                             //  선 만들기(충돌 감지를 위한)
                                                             //  Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.green, 0.5f);

        // 충돌 감지 시
        RaycastHit Collided_object = new RaycastHit(); // 충돌된 객체

        if (Physics.Raycast(rightHandController.position, rightHandController.forward, out Collided_object, raycastDistance))
        {
            layser.SetPosition(1, Collided_object.point);

            //만약 백그라운드 선택을 했다면 
            if (!isBg)
            {
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("DefaultBrush"))
                {

                    brushImg.SetActive(false);
                    brushAni.SetActive(true);

                }
                else
                {

                    brushImg.SetActive(true);
                    brushAni.SetActive(false);

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("HoloBrush"))
                {

                    holoBrushImg.SetActive(false);
                    holoBrushAni.SetActive(true);

                }
                else
                {

                    holoBrushImg.SetActive(true);
                    holoBrushAni.SetActive(false);

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Eraser"))
                {

                    eraserImg.SetActive(false);
                    eraserAni.SetActive(true);

                }
                else
                {

                    eraserImg.SetActive(true);
                    eraserAni.SetActive(false);

                }


                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Background"))
                {

                    bgImg.SetActive(false);
                    bgBoxAni.SetActive(true);

                }
                else
                {

                    bgImg.SetActive(true);
                    bgBoxAni.SetActive(false);

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("BoxBrush"))
                {

                    boxbrushImg.SetActive(false);
                    boxbrushAni.SetActive(true);

                }
                else
                {

                    boxbrushImg.SetActive(true);
                    boxbrushAni.SetActive(false);

                }
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("TriangleBrush"))
                {

                    triangleBrushImg.SetActive(false);
                    triangleBrushAni.SetActive(true);

                }
                else
                {

                    triangleBrushImg.SetActive(true);
                    triangleBrushAni.SetActive(false);

                }
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("WireFrameBrush"))
                {

                    wireFrameBrushImg.SetActive(false);
                    wireFrameBrushAni.SetActive(true);

                }
                else
                {

                    wireFrameBrushImg.SetActive(true);
                    wireFrameBrushAni.SetActive(false);

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("SnapShot"))
                {

                    snapShotImg.SetActive(false);
                    snapShotAni.SetActive(true);

                }
                else
                {

                    snapShotImg.SetActive(true);
                    snapShotAni.SetActive(false);

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("SaveMesh"))
                {

                    saveMeshImg.SetActive(false);
                    saveMeshAni.SetActive(true);

                }
                else
                {

                    saveMeshImg.SetActive(true);
                    saveMeshAni.SetActive(false);

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("ButterFly"))
                {

                    butterflyImg.SetActive(false);
                    butterflyAni.SetActive(true);

                }
                else
                {

                    butterflyImg.SetActive(true);
                    butterflyAni.SetActive(false);

                }


            }


            Vector3 hitPosition = Collided_object.point - ColorPickerObj.position;
            // 리모콘에 큰 동그라미 부분을 누를 경우
            if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
            {

                if (myPicker != null)
                {
                    myPicker.OnPress(hitPosition);

                }

                // 충돌 객체의 태그가 Eraser 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Eraser"))
                {

                    eraser.SetActive(true);
                    brush.SetActive(false);
                    boxbrush.SetActive(false);
                    triangleBrush.SetActive(false);
                    holoBrush.SetActive(false);
                    wireFrameBrush.SetActive(false);
                    snapShot.SetActive(false);

                }
                // 충돌 객체의 태그가 DefaultBrush 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("DefaultBrush"))
                {
                    eraser.SetActive(false);
                    brush.SetActive(true);
                    boxbrush.SetActive(false);
                    triangleBrush.SetActive(false);
                    holoBrush.SetActive(false);
                    wireFrameBrush.SetActive(false);
                    snapShot.SetActive(false);
                }
                // 충돌 객체의 태그가 BoxBrush 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("BoxBrush"))
                {
                    boxbrush.SetActive(true);
                    eraser.SetActive(false);
                    brush.SetActive(false);
                    triangleBrush.SetActive(false);
                    holoBrush.SetActive(false);
                    wireFrameBrush.SetActive(false);
                    snapShot.SetActive(false);
                }

                // 충돌 객체의 태그가 Triangle 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("TriangleBrush"))
                {
                    boxbrush.SetActive(false);
                    eraser.SetActive(false);
                    brush.SetActive(false);
                    triangleBrush.SetActive(true);
                    holoBrush.SetActive(false);
                    wireFrameBrush.SetActive(false);
                    snapShot.SetActive(false);
                }
                // 충돌 객체의 태그가 Holo 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("HoloBrush"))
                {
                    boxbrush.SetActive(false);
                    eraser.SetActive(false);
                    brush.SetActive(false);
                    triangleBrush.SetActive(false);
                    holoBrush.SetActive(true);
                    wireFrameBrush.SetActive(false);
                    snapShot.SetActive(false);
                }
                // 충돌 객체의 태그가 Wire 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("WireFrameBrush"))
                {
                    boxbrush.SetActive(false);
                    eraser.SetActive(false);
                    brush.SetActive(false);
                    triangleBrush.SetActive(false);
                    holoBrush.SetActive(false);
                    wireFrameBrush.SetActive(true);
                    snapShot.SetActive(false);
                }
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("SnapShot"))
                {
                    boxbrush.SetActive(false);
                    eraser.SetActive(false);
                    brush.SetActive(false);
                    triangleBrush.SetActive(false);
                    holoBrush.SetActive(false);
                    wireFrameBrush.SetActive(false);
                    snapShot.SetActive(true);
                }
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("SaveMesh"))
                {
                    //SaveProject saveProjectScript = saveProject.GetComponent<SaveProject>();
                    // SaveProject saveProject = GetComponent<SaveProject>();
                    //saveProjectScript.Save();

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("ButterFly"))
                {
                    //기능
                    Execute();
                }



                // 충돌 객체의 태그가 Background 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Background"))
                {
                    isBg = true;
                    BgOn();

                }
                //뒤로가기 버튼 클릭
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Back"))
                {

                    isBg = false;
                    BgOff();
                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Bg_Space"))
                {
                    RenderSettings.skybox = spaceMat;

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Bg_Sea"))
                {
                    RenderSettings.skybox = seaMat;

                }

                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Bg_Earth"))
                {
                    RenderSettings.skybox = earthMat;

                }
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("Bg_Night"))
                {
                    RenderSettings.skybox = nightMat;

                }

            }
            else if (myPicker != null)
            {
                myPicker.OnDrag(hitPosition);
            }

        }

        else
        {
            // 레이저에 감지된 것이 없기 때문에 레이저 초기 설정 길이만큼 길게 만든다.
            layser.SetPosition(1, transform.position + (transform.forward * raycastDistance));

            // 최근 감지된 오브젝트가 Button인 경우
            // 버튼은 현재 눌려있는 상태이므로 이것을 풀어준다.
            if (currentObject != null)
            {
                //  currentObject.GetComponent<Button>().OnPointerExit(null);
                currentObject = null;
            }

        }
    }

    void BgOn()
    {

        eraserImg.SetActive(false);
        brushImg.SetActive(false);
        boxbrushImg.SetActive(false);
        bgImg.SetActive(false);

        triangleBrushImg.SetActive(false);
        holoBrushImg.SetActive(false);
        wireFrameBrushImg.SetActive(false);
        snapShotImg.SetActive(false);
        saveMeshImg.SetActive(false);
        butterflyImg.SetActive(false);


        brushAni.SetActive(false);
        holoBrushAni.SetActive(false);
        eraserAni.SetActive(false);
        bgBoxAni.SetActive(false);
        boxbrushAni.SetActive(false);
        triangleBrushAni.SetActive(false);
        wireFrameBrushAni.SetActive(false);
        snapShotAni.SetActive(false);
        saveMeshAni.SetActive(false);
        butterflyAni.SetActive(false);

        //뒤로가기 버튼 , 배경들 
        bg_back.SetActive(true);
        bg_space.SetActive(true);
        bg_sea.SetActive(true);
        bg_earth.SetActive(true);
        bg_night.SetActive(true);

    }

    void BgOff()
    {
        eraserImg.SetActive(true);
        brushImg.SetActive(true);
        boxbrushImg.SetActive(true);
        bgImg.SetActive(true);
        triangleBrushImg.SetActive(true);
        holoBrushImg.SetActive(true);
        wireFrameBrushImg.SetActive(true);
        snapShotImg.SetActive(true);
        saveMeshImg.SetActive(true);
        butterflyImg.SetActive(true);

        brushAni.SetActive(true);
        holoBrushAni.SetActive(true);
        eraserAni.SetActive(true);
        bgBoxAni.SetActive(true);
        boxbrushAni.SetActive(true);
        triangleBrushAni.SetActive(true);
        wireFrameBrushAni.SetActive(true);
        snapShotAni.SetActive(true);
        saveMeshAni.SetActive(true);
        butterflyAni.SetActive(true);

        bg_back.SetActive(false);
        bg_space.SetActive(false);
        bg_sea.SetActive(false);
        bg_earth.SetActive(false);
        bg_night.SetActive(false);

    }


}