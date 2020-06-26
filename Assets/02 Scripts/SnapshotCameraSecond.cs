using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//셀카봉을 생성하면 Image가 보여야 한다
//셀카봉이 켜져있는 동안 촬영버튼을 누르면 
//촬영하고 깜빡 꺼진다
//다시 켜져서 화면을 볼 수 있다.

[RequireComponent(typeof(Camera))] //makes sure that we are always using this script on our camera object...
public class SnapshotCameraSecond : MonoBehaviour
{
    Camera snapCam;
    int resWidth = 256;
    int resHeight = 256;
    bool photoSwitch;
    AudioSource audio;

    void Awake()
    {
        snapCam = GetComponent<Camera>();

        //usually cameras render directly to screen, but it is sometimes useful to make a camera render into a texture.
        //this is done by creating a RenderTexture object and setting it as targetTexture on the camera. 
        //The camera will then render into that camera.

        //if there isn't a render texture attached, because when targetTexture is null camera renders to screen.
        if (snapCam.targetTexture == null)
        {
            snapCam.targetTexture = new RenderTexture(resWidth, resHeight, 24);
        }
        else
        {
            resWidth = snapCam.targetTexture.width;
            resHeight = snapCam.targetTexture.height;
        }
    }

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void CallTakeSnapShot()
    {
        photoSwitch = true;
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            CallTakeSnapShot();
            audio.Play();
        }
    }

    void LateUpdate()
    {
        if (photoSwitch)
        {
            RenderTexture.active = snapCam.targetTexture;
            snapCam.Render();
            
            Texture2D snapshot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            snapshot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);

            //png file
            byte[] bytes = snapshot.EncodeToPNG();
            string fileName = SnapshotName();
            System.IO.File.WriteAllBytes(fileName, bytes);
            photoSwitch = false;
        }
    }

    string SnapshotName()
    {
        return string.Format("{0}/Snapshots/snap_{1}x{2} {3}.png",
            Application.dataPath,
            resWidth,
            resHeight,
            System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
    }
}
