using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mask : MonoBehaviour
{
    public int life;
    private float speed;
    public float minspeed;
    public float maxspeed;
    playermove play;
    public GameObject blast;
    
    
    void Start()
    {
        
        play = GameObject.FindGameObjectWithTag("Player").GetComponent<playermove>();
    }

  
    void Update()
    {
      
        speed = Random.Range(minspeed, maxspeed);
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D hit)
    {
        
        if (hit.tag == "Player")
        {

            play.getheal(life);
            Destroy(gameObject);
            Instantiate(blast, transform.position, Quaternion.identity);
        }
    }
}
