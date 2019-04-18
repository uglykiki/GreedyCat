using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SweetSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Sweet;
    
    private BoxCollider2D col;
    float x1, x2;

    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<BoxCollider2D> ();
        x1 = transform.position.x - col.bounds.size.x / 4f; 
        x2 = transform.position.x +  col.bounds.size.x / 4f; 
    }


    void Start ()
    {
        StartCoroutine (SpawnSweet(1f));
    }
    
    IEnumerator SpawnSweet(float time){
        yield return new WaitForSeconds (1);
       
        Vector3 temp = transform.position;
        temp.x = Random.Range (x1, x2); 
        
        Instantiate (Sweet[Random.Range(0, Sweet.Length)], temp, Quaternion.identity);
        StartCoroutine (SpawnSweet(Random.Range(1f, 4f)));
        
    }

    
}
