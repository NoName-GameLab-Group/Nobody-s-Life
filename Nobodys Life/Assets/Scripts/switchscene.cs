using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class switchscene : MonoBehaviour
{
     [SerializeField] private GameObject texttest;
     [SerializeField] private GameObject objecta;
     [SerializeField] private bool triggerActive = false; 


            public void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player")&& (Input.GetKeyUp(KeyCode.E)||Input.GetKeyUp(KeyCode.E)))
            {
             SceneManager.LoadScene(2);
            }
        } 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
