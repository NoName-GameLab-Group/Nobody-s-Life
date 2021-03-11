using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

        [SerializeField] bool dayActive = true;
        [SerializeField] float daySpeed = 12.0f;

        [SerializeField] GameObject Sun;
        [SerializeField] GameObject Moon;



    // Start is called before the first frame update
    void Start()
    {
                timeSetDay();

        
    }

    // Update is called once per frame
    void Update()
    {
        timeProgress(daySpeed);
    }

    void timeProgress(float speed){

        transform.RotateAround(Vector3.zero,Vector3.right,speed*Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }


    void timeSetDay(){
     Sun.transform.position = new Vector3(0, 500, 0);
     Moon.transform.position = new Vector3(0, -500, 0);


    }

    void timeSetNight(){
     Sun.transform.position = new Vector3(0, -500, 0);
     Moon.transform.position = new Vector3(0, 500, 0);
        
    }
}
