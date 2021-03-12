using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField]
    public Camera cam;
     Ray ray;
    RaycastHit hit2;
    void Awake()
    {
        cam = Camera.main;
    }

    void Update(){
        ray.origin = transform.position;
        ray.direction = transform.forward;
        if(Physics.Raycast(ray, out hit2) && hit2.transform.tag == "Test")
        {
            Debug.Log("Hit (Test)");
        }
        Debug.DrawRay(ray.origin,ray.direction, Color.red);
        RayCheck();
    }
    void RayCheck(){
    Vector3 orig = cam.transform.position;
    Vector3 destin = cam.transform.forward;
    float distance = 400f;
    RaycastHit hit;
    if (Physics.Raycast(orig,destin, out hit, distance)){
                    Debug.Log("Hit (something)");

        if (hit.transform.tag == "Test"){

            Debug.Log("Hit (Test)");
            if (Input.GetKeyDown(KeyCode.E))
            {
                hit.transform.gameObject.GetComponent<ObjectInteraction>().enabled = true;
            }
        }
    }
    }
}