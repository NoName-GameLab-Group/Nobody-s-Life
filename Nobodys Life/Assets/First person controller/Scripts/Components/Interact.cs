using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
        [SerializeField]

        public Object warning;
    [SerializeField]
    public Camera cam;
        [SerializeField]
    public float distance =16000f;
    [SerializeField]

    public int counter;
        [SerializeField]

    public GameObject test;

        [SerializeField]

    public GameObject test2;
     Ray ray;
    RaycastHit hit2;
    void Awake()
    {
       // cam = Camera.main;
//        test2.SetActive(true);
    }

    void FixedUpdate(){
        ray.origin = transform.position;
        ray.direction = transform.forward;
         float distance = 90000f;
        test2.SetActive(true);

        if(Physics.Raycast(ray, out hit2,distance) && hit2.transform.tag == "Test")
        {
           // Debug.Log("Hit (Test)");
            counter++;
            test2.SetActive(false);

        }else{

        test2.SetActive(true);
        }
        if (counter > 500){

                Destroy(test);
               // Destroy(test2);
                SceneManager.LoadScene(0);

        }
      
    }

}