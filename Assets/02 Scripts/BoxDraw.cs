﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*목표
1. Brush의 굵기는 diameter 변수로써 조절할 수 있다.
2. Space키(VR에서는 Right Trigger)를 누르는 순간 우리가 Mesh를 변형시킬 MeshObject가 Scene에 생성된다.
3. Brush의 Center는 unitDistance라는 거리를 벗어날 때마다 그 기준점이 갱신되며,
4. 기준점이 갱신될 때마다 이전 기준점 중 Top과 Bottom은 우리가 그리는 Mesh의 새로운 Vertex가 된다.
5. 새로운 Vertex를 이용해 기존의 triangle들에 이어 새로운 triangle 들을 그린다.
6. Space키를 때는 순간 우리가 그린 MeshObject가 Scene의 Drawing 오브젝트에 Child로 들어간다.
7. 하지만 우리가 그린 Mesh의 vertex가 3개 미만이라면 그 오브젝트는 그냥 파괴한다.
*/

/*
문제점
1. 맨 처음 그릴 때 저절로 4vertex짜리 오브젝트가 생성됨
2. 드로잉 툴에서 멀찍이 떨어진 거리에서 그림이 그려짐 
*/

public class BoxDraw : MonoBehaviour
{
    #region fields
    GameObject _topLeft, _center, _bottomLeft, _topRight, _bottomRight;

    public GameObject meshFactory; //새로이 생성되는 MeshObj
    [SerializeField] GameObject workingMeshObj; //현재 작업 중인 MeshObj
    [SerializeField] Mesh workingMesh; //현재 작업 중인 Mesh

    [SerializeField] GameObject workingMeshObj2; //현재 작업 중인 MeshObj
    [SerializeField] Mesh workingMesh2; //현재 작업 중인 Mesh

    bool _isDrawing; //
    bool _isNew; //새로운 mesh 확인키


    public float unitDistance; //기준점 변경 거리
    Vector3 _baseTopLeft, _baseCenter, _baseBottomLeft, _baseTopRight, _baseBottomRight; //기준점이 되는 top, center, bottom의 

    //매사이클마다 비워줘야 한다.
    List<Vector3> vertexList = new List<Vector3>();
    List<int> triangles = new List<int>();

    List<Vector3> vertexList2 = new List<Vector3>();
    List<int> triangles2 = new List<int>();


    public Material defaultMat;
    public ColorPickerUnityUI ColorPickerToUse;
    #endregion

    void Start()
    {
        _topLeft = transform.Find("TopLeft").gameObject;
        _center = transform.Find("Center").gameObject;
        _bottomLeft = transform.Find("BottomLeft").gameObject;
        _topRight = transform.Find("TopRight").gameObject;
        _bottomRight = transform.Find("BottomRight").gameObject;

        _isDrawing = false;
        _isNew = false;


        workingMeshObj = null;
        workingMesh = null;
    }

    void Update()
    {
        DrawKey();
        CreateNewMesh();
        DrawMesh();
    }

    /// <summary>
    /// 그리는 중인지 확인키값 지정 함수
    /// </summary>
    void DrawKey()
    {
        //D키를 누르는 중이라면? 
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger,OVRInput.Controller.RTouch))
        {
            _isDrawing = true;
            print("yes");
        }
        else
        {
            _isDrawing = false;
        }

        //누르는 순간과 때는 순간 각각 오브젝트 생성 및 분리
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            _isNew = true;
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            _isNew = false;
        }

        //print("isNew : " + _isNew);
        //print("isDrawing : " + _isDrawing);
    }

    /// <summary>
    /// 새로운 MeshObject를 생성하고 그걸 작업중인 MeshObject 변수로 할당하고, 작업이 끝나면 Drawing에 집어넣고 작업중인 MeshObject에는 null값 지정 함수.
    /// </summary>
    void CreateNewMesh()
    {
        if (_isNew && OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            GameObject meshObj = Instantiate(meshFactory);
            meshObj.transform.position = Vector3.zero; //_center.transform.position;

            //새로운 Mesh를 만들어 MeshFilter에 할당 해줘야 한다
            Mesh mesh = new Mesh();
            meshObj.GetComponent<MeshFilter>().mesh = mesh;


            //매트리얼을 새로 생성하고 싶다.
            Material mat = new Material(defaultMat);
            mat.color = ColorPickerToUse.value;
            meshObj.GetComponent<MeshRenderer>().material = mat;



            //새로운 MeshObj를 "작업 중인 오브젝트" 변수에 할당
            workingMeshObj = meshObj;
            //작업 중인 MeshObj의 mesh를 "작업 중인 메쉬" 변수에 할당
            workingMesh = workingMeshObj.GetComponent<MeshFilter>().mesh;

            //그리기 시작할 때의 vertex는 네개다.
            vertexList.Add(_topLeft.transform.position);
            print(_topLeft.transform.position);
            vertexList.Add(_bottomLeft.transform.position);
            vertexList.Add(_topRight.transform.position);
            vertexList.Add(_bottomRight.transform.position);

            //작업 중인 메쉬에 우선적으로 이 네 점을 넣어준다.
            workingMesh.vertices = vertexList.ToArray();

            triangles.Add(vertexList.Count - 4);
            triangles.Add(vertexList.Count - 3);
            triangles.Add(vertexList.Count - 2);

            triangles.Add(vertexList.Count - 2);
            triangles.Add(vertexList.Count - 3);
            triangles.Add(vertexList.Count - 1);

            if (Mirror.Mirroring)
            {
                GameObject meshObj2 = Instantiate(meshFactory);
                meshObj2.transform.position = Vector3.zero; //_center.transform.position;

                //새로운 Mesh를 만들어 MeshFilter에 할당 해줘야 한다
                Mesh mesh2 = new Mesh();
                meshObj2.GetComponent<MeshFilter>().mesh = mesh2;


                //매트리얼을 새로 생성하고 싶다.
                Material mat2 = new Material(defaultMat);
                mat2.color = ColorPickerToUse.value;
                meshObj2.GetComponent<MeshRenderer>().material = mat2;


                //새로운 MeshObj를 "작업 중인 오브젝트" 변수에 할당
                workingMeshObj2 = meshObj2;
                //작업 중인 MeshObj의 mesh를 "작업 중인 메쉬" 변수에 할당
                workingMesh2 = workingMeshObj2.GetComponent<MeshFilter>().mesh;

                //그리기 시작할 때의 vertex는 네개다.
                vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _topLeft.transform.position.x, _topLeft.transform.position.y, _topLeft.transform.position.z));
                print(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _topLeft.transform.position.x, _topLeft.transform.position.y, _topLeft.transform.position.z));
                print(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _topLeft.transform.position.x, _topLeft.transform.position.y, _topLeft.transform.position.z));

                vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _bottomLeft.transform.position.x, _bottomLeft.transform.position.y, _bottomLeft.transform.position.z));
                vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _topRight.transform.position.x, _topRight.transform.position.y, _topRight.transform.position.z));
                vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _bottomRight.transform.position.x, _bottomRight.transform.position.y, _bottomRight.transform.position.z));

                //작업 중인 메쉬에 우선적으로 이 네 점을 넣어준다.
                workingMesh2.vertices = vertexList2.ToArray();

                triangles2.Add(vertexList2.Count - 4);
                triangles2.Add(vertexList2.Count - 3);
                triangles2.Add(vertexList2.Count - 2);

                triangles2.Add(vertexList2.Count - 2);
                triangles2.Add(vertexList2.Count - 3);
                triangles2.Add(vertexList2.Count - 1);
            }
        }
        else if (!_isNew && OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch)) //약간 헷갈림...
        {
            GameObject drawing = GameObject.Find("Drawing");

            //workingMeshObj의 vertex가 2개 초과일 때는 Drawing의 Child로,
            if (vertexList.Count > 4)
            {
                workingMeshObj.GetComponent<MeshCollider>().sharedMesh = workingMesh; //mesh 다 그리면 mesh collider 입히기!!
                workingMeshObj.transform.SetParent(drawing.transform, true);
            }
            else //vertex가 2개 이하일 때는 Destroy 한다.
            {
                Destroy(workingMeshObj);
            }
            
            //작업이 끝나면 현재 작업중인 workingMeshObj와 workingMesh 변수에 null을 할당
            workingMeshObj = null;
            workingMesh = null;

            //드로잉 사이클마다 vertexList와 triangles를 비워줘야 한다.
            vertexList.Clear();
            triangles.Clear();


            if (Mirror.Mirroring)
            {
                //workingMeshObj의 vertex가 2개 초과일 때는 Drawing의 Child로,
                if (vertexList2.Count > 4)
                {
                    workingMeshObj2.GetComponent<MeshCollider>().sharedMesh = workingMesh2; //mesh 다 그리면 mesh collider 입히기!!
                    workingMeshObj2.transform.SetParent(drawing.transform, true);
                }
                else //vertex가 2개 이하일 때는 Destroy 한다.
                {
                    Destroy(workingMeshObj2);
                }

                //작업이 끝나면 현재 작업중인 workingMeshObj와 workingMesh 변수에 null을 할당
                workingMeshObj2 = null;
                workingMesh2 = null;

                //드로잉 사이클마다 vertexList와 triangles를 비워줘야 한다.
                vertexList2.Clear();
                triangles2.Clear();
            }
        }
    }

    /// <summary>
    /// 기준center와 현재 center의 거리를 재는 함수. 거리값을 반환
    /// </summary>
    /// <returns></returns>
    float MeasureDistance()
    {
        float distance = 0f;
        distance = Vector3.Distance(_baseCenter, _center.transform.position);
        return distance;
    }

    /// <summary>
    /// 기준점을 새롭게 할당하는 함수 vg 
    /// </summary>
    void NewBasePoints()
    {
        _baseTopLeft = new Vector3(_topLeft.transform.position.x, _topLeft.transform.position.y, _topLeft.transform.position.z);
        _baseTopRight = new Vector3(_topRight.transform.position.x, _topRight.transform.position.y, _topRight.transform.position.z);
        _baseCenter = new Vector3(_center.transform.position.x, _center.transform.position.y, _center.transform.position.z);
        _baseBottomLeft = new Vector3(_bottomLeft.transform.position.x, _bottomLeft.transform.position.y, _bottomLeft.transform.position.z);
        _baseBottomRight = new Vector3(_bottomRight.transform.position.x, _bottomRight.transform.position.y, _bottomRight.transform.position.z);
    }

    /// <summary>
    /// Mesh를 그리는 함수. 기준점이 변경될 때마다 기준점을 새롭게 할당하고, 이전 기준점들로 vertex를 추가하고 삼각형도 그린다.
    /// </summary>
    void DrawMesh()
    {
        float currentDistance = MeasureDistance();
        if (_isDrawing && currentDistance > unitDistance) //기준 거리 초과되면!
        {
            if (workingMeshObj != null && workingMesh != null)
            {
                //우리가 그리는 Mesh의 Vertex 모음에 두개의 vertice(top -> bottom 순서로)를 넣는다. 
                vertexList.Add(_topLeft.transform.position);
                vertexList.Add(_bottomLeft.transform.position);
                vertexList.Add(_topRight.transform.position);
                vertexList.Add(_bottomRight.transform.position);

                triangles.Add(vertexList.Count - 8);
                triangles.Add(vertexList.Count - 7);
                triangles.Add(vertexList.Count - 4);

                triangles.Add(vertexList.Count - 4);
                triangles.Add(vertexList.Count - 7);
                triangles.Add(vertexList.Count - 3);

                triangles.Add(vertexList.Count - 8);
                triangles.Add(vertexList.Count - 6);
                triangles.Add(vertexList.Count - 4);

                triangles.Add(vertexList.Count - 6);
                triangles.Add(vertexList.Count - 4);
                triangles.Add(vertexList.Count - 2);

                triangles.Add(vertexList.Count - 6);
                triangles.Add(vertexList.Count - 5);
                triangles.Add(vertexList.Count - 2);

                triangles.Add(vertexList.Count - 2);
                triangles.Add(vertexList.Count - 5);
                triangles.Add(vertexList.Count - 1);

                triangles.Add(vertexList.Count - 5);
                triangles.Add(vertexList.Count - 7);
                triangles.Add(vertexList.Count - 1);

                triangles.Add(vertexList.Count - 1);
                triangles.Add(vertexList.Count - 7);
                triangles.Add(vertexList.Count - 3);

                //추가된 vertex로 이어그린다
                workingMesh.Clear();
                workingMesh.MarkDynamic(); //성능업!
                workingMesh.vertices = vertexList.ToArray();
                workingMesh.triangles = triangles.ToArray();

                //workingMesh.RecalculateNormals();
            }
            else
            {
                print("No WorkingMeshObj to work on");
            }

            if (Mirror.Mirroring)
            {
                if (workingMeshObj2 != null && workingMesh2 != null)
                {
                    //우리가 그리는 Mesh의 Vertex 모음에 두개의 vertice(top -> bottom 순서로)를 넣는다. 
                    vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _topLeft.transform.position.x, _topLeft.transform.position.y, _topLeft.transform.position.z));
                    vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _bottomLeft.transform.position.x, _bottomLeft.transform.position.y, _bottomLeft.transform.position.z));
                    vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _topRight.transform.position.x, _topRight.transform.position.y, _topRight.transform.position.z));
                    vertexList2.Add(CalculateReflection.GetReflection(Mirror.MirrorEquation.x, Mirror.MirrorEquation.y, _bottomRight.transform.position.x, _bottomRight.transform.position.y, _bottomRight.transform.position.z));

                    triangles2.Add(vertexList2.Count - 8);
                    triangles2.Add(vertexList2.Count - 7);
                    triangles2.Add(vertexList2.Count - 4);

                    triangles2.Add(vertexList2.Count - 4);
                    triangles2.Add(vertexList2.Count - 7);
                    triangles2.Add(vertexList2.Count - 3);

                    triangles2.Add(vertexList2.Count - 8);
                    triangles2.Add(vertexList2.Count - 6);
                    triangles2.Add(vertexList2.Count - 4);

                    triangles2.Add(vertexList2.Count - 6);
                    triangles2.Add(vertexList2.Count - 4);
                    triangles2.Add(vertexList2.Count - 2);

                    triangles2.Add(vertexList2.Count - 6);
                    triangles2.Add(vertexList2.Count - 5);
                    triangles2.Add(vertexList2.Count - 2);

                    triangles2.Add(vertexList2.Count - 2);
                    triangles2.Add(vertexList2.Count - 5);
                    triangles2.Add(vertexList2.Count - 1);

                    triangles2.Add(vertexList2.Count - 5);
                    triangles2.Add(vertexList2.Count - 7);
                    triangles2.Add(vertexList2.Count - 1);

                    triangles2.Add(vertexList2.Count - 1);
                    triangles2.Add(vertexList2.Count - 7);
                    triangles2.Add(vertexList2.Count - 3);

                    //추가된 vertex로 이어그린다
                    workingMesh2.Clear();
                    workingMesh2.MarkDynamic(); //성능업!
                    workingMesh2.vertices = vertexList2.ToArray();
                    workingMesh2.triangles = triangles2.ToArray();

                    //workingMesh.RecalculateNormals();
                }
                else
                {
                    print("No WorkingMeshObj to work on");
                }
            }

            NewBasePoints(); //기준점 변경!
        }
    }
}