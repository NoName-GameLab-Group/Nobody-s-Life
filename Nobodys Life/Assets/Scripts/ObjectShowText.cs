    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class ObjectShowText : MonoBehaviour
    {

       // String textcontent = "";

        [SerializeField] private GameObject texttest;

        [SerializeField] private bool triggerActive = false;
 
        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = true;
            }
        }

        public void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player")&& Input.GetKeyDown(KeyCode.E))
            {
                triggerActive = true;
                texttest.SetActive(false);
                Destroy(this.gameObject);
            }
        }
 
        public void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = false;
            }
        } 
        void Update()
        {
            if (triggerActive){
                Primary();
            }else {
                Secondary();
            }
        } 
        public void Primary()
        {     
        texttest.SetActive(true);    
        }
        public void Secondary()
        {     
        texttest.SetActive(false);    
        }
    }