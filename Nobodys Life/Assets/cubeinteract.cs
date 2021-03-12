using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cubeinteract : MonoBehaviour
{
// Start is called before the first frame update
 float distance  = 0.3f;
 private GameObject goPlayer;
 Rect rect = new Rect(50,50,300,50);
 
 void Start() {
   goPlayer = GameObject.Find("Player");
 }
 
 void OnGUI() {
     if ((goPlayer.transform.position - transform.position).magnitude < distance)
         GUI.Label(rect, "Some Text");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
