using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource menuSound;
    public void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    private void Update()
    {
        
    }

    public void AdjustVolume()
    {
        menuSound.volume = volumeSlider.value/100;
    }
}
