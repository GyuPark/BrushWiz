using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Layser : MonoBehaviour
{
    private LineRenderer layser;        // 레이저
   
    private GameObject currentObject;   // 가장 최근에 충돌한 객체를 저장하기 위한 객체

    public Transform rightHandController;

    public Image image;

    float time = 0;
    float endTime = 1f;

    //카메라의 alpha값을 변경하고 싶다.



    // 파티클
    public ParticleSystem light;

    public float raycastDistance = 100f; // 레이저 포인터 감지 거리


    LeftController laserOnOff;

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


        laserOnOff = GameObject.Find("LeftHandAnchor").GetComponent<LeftController>();
       

    }

    // Update is called once per frame
    void Update()
    {
        //ColorPicker();
        LaserPlaying();
       

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

            // 리모콘에 큰 동그라미 부분을 누를 경우
            if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
            {

                
                // 충돌 객체의 태그가 Eraser 경우
                if (Collided_object.transform.gameObject.layer == LayerMask.NameToLayer("NextScene"))
                {

                    StartCoroutine(FadeInScreen());
 
                }
          
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

    float lightTime = 0f;
    float endLightTime = 10f;

    IEnumerator FadeInScreen()
    {


        laserOnOff.isStart = true;

        
        light.gameObject.SetActive(true);
        light.Play();

        while (light.transform.localScale.x < 0.1f)
        {
            lightTime += Time.deltaTime/ endLightTime;
            light.transform.localScale = new Vector3(lightTime, lightTime, lightTime);

            yield return null;

        }


        yield return new WaitForSeconds(3f);

       
        time = 0;
        Color alpha = image.color;

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / endTime;
            alpha.a = Mathf.Lerp(0, 1, time);
            image.color = alpha;
            yield return null;

        }
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Draw");
    }



}