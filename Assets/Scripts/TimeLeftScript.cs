using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLeftScript : MonoBehaviour
{
    public GameObject timeIsUp, restartButton;
    Text text;
    public static float timeLeft = 10f;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

    }


    // Update is called once per frame
    public void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if(timeLeft <= 0)
        {
    
        }
     }


}
