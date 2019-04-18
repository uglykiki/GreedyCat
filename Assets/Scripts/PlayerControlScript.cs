using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    float dirX, dirY;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX * 10, dirY * 10);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        switch (col.gameObject.tag){
            case "plus1sec":
                TimeLeftScript.timeLeft += 5f; 
                col.gameObject.SetActive(false);
            break;
            case "minus2sec":
                TimeLeftScript.timeLeft -= 2f;
                col.gameObject.SetActive(false);
                break;
                        }
    }
}
