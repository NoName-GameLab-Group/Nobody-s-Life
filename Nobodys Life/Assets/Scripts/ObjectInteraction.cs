using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    public float startTime;
    public float radius = 3f;
    [SerializeField] private GameObject test;
    [SerializeField]  bool isactive = false;

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
    void Start(){
        isactive = false;
    }
    void OnEnable(){
        isactive = !isactive;
    }

    void Update(){
        if (isactive){

          // test.SetActive(true);
            test.GetComponent<Renderer>().enabled = false;



        }else{
         test.GetComponent<Renderer>().enabled = true;

           //test.SetActive(false);


        }


    }



}
