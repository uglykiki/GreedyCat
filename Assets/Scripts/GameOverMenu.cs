using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour
{
    // public GameObject playButton;

    // Start is called before the first frame update
        void Start()
    {
       
    }

    void Restart()
    {
        SceneManager.LoadScene("Game");
    }
   
    public void QuitGame()
    {
        Application.Quit();
    }
}
