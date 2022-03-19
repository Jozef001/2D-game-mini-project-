using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public int beat;
    float speed;
    public float minspeed;
    public float maxspeed;
    playermove player;
    public GameObject explosion;
    
   
    
    void Start()
    {
        speed = Random.Range(minspeed, maxspeed);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playermove>();
       
    }

   
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.tag == "Player")
        {
            
            player.getdamage(beat);
            Destroy(gameObject);
            
        }
        if (hit.tag=="ground")
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            
            
        }

        
    }
}
