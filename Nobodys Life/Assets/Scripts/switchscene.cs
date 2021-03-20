using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class switchscene : MonoBehaviour
{
            public void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player")&& (Input.GetKeyUp(KeyCode.E)||Input.GetKeyUp(KeyCode.E)))
            {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        } 

}
