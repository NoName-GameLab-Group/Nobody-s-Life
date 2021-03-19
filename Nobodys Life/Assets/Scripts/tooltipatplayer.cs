using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tooltipatplayer : MonoBehaviour
{

    [SerializeField]
     public Camera targetCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.LookAt(transform.position + targetCamera.transform.rotation * Vector3.forward,
         targetCamera.transform.rotation * Vector3.up);
    }
}
