using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{


  
    public GameObject playButton;

    // Use this for initialization
    void Start()
    {
       
    }


    public void PlayGame()
    {
        // Load level1
        SceneManager.LoadScene("Game");
    }
   

    public void QuitGame()
    {
        Application.Quit();
    }
}
