using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demostart : MonoBehaviour
{

         [SerializeField] private GameObject intro;
                  [SerializeField] private GameObject menu;


                   [SerializeField]    public AudioSource audioSource;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        
    }


    public void BeginDemo(){
                        GameObject camera = GameObject.Find("Main Camera");

        var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,"Game Menu 1.mp4"); 

        Destroy(intro.gameObject);
        menu.SetActive(true);
        videoPlayer.Play();
        audioSource.Play();

    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
    

    }
}
