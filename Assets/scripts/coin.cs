using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{


    public float speed;
    public int point;
    playermove player;
    static public int globalpt;
    public Text storecoin;
    skinmanagerduplicate store;
    public Slider slideru; 
    




    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playermove>();
       
        point = 1;
        
    }

    
    void Update()
    {
       // Debug.Log(globalpt);
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        globalpt = PlayerPrefs.GetInt("coinstorage", 0);
        storecoin.text = globalpt.ToString();

       



    }

    void OnTriggerEnter2D(Collider2D cointouch)
    {
        if (cointouch.tag == "Player")
        {
            
            player.getcoin(point);
            Destroy(gameObject);
        }
    }

   
   
        
    
}
