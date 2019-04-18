using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.Collections;
using System.Collections.Generic;
public class Score : MonoBehaviour
{
    private Text scoreText;
    private int score = 0;
    // Start is called before the first frame update

    void Awake()
    {
        scoreText = GameObject.Find ("ScoreText").GetComponent<Text> (); 
        scoreText.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D target){
        if (target.tag == "minus2sec"){
            // tranform.position = new Vector2 (0,100);
            gameObject.SetActive(false);
            target.gameObject.SetActive (false);
            StartCoroutine (RestartGame());
        }
        if (target.tag == "plus1sec"){
            target.gameObject.SetActive (false);
            score++;
            scoreText.text = score.ToString ();

        }
    }

    IEnumerator RestartGame(){
        yield return new WaitForSecondsRealtime (2f);
        SceneManager.LoadScene ("Main");
    }
    // Start is called before the first frame update

    // Update is called once per frame
}
