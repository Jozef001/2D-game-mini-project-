 using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{
    public float input;
    public float speed;


    Rigidbody2D rb;
    Animator anim;


    public GameObject burst;
    public int health;
    public Text healthtext;
    public GameObject mask;
    public GameObject sheild;

    public GameObject lose;
    public GameObject pause;

  /*  private bool leftmove;
    private bool rightmove;
    public float vegam;
    public GameObject joystick; */


    public static int coins;
    public GameObject coinsplash;
    public Text coinboard;


     AudioSource source;


    void Start()
    {

        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        health = 3;
        coins = PlayerPrefs.GetInt("coinstorage", 0);
        coinboard.text = PlayerPrefs.GetInt("coinstorage").ToString();
      //  leftmove = false;
      //  rightmove = false;

        

    }
    private void Update()
    {


        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }



        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }



        if (health == 0)
        {
            mask.SetActive(false);
            sheild.SetActive(false);
        }
        else
        {
            mask.SetActive(true);
            sheild.SetActive(true);
        }


        PlayerPrefs.SetInt("coinstorage", coins);
        coinboard.text = PlayerPrefs.GetInt("coinstorage").ToString();

        

       
      
       // movement();


    }



    void FixedUpdate()
    {
        input = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }




    public void getheal(int life)
    {
        health = health + life;
        healthtext.text = (health).ToString();
    }




    public void getdamage(int beat)
    {

        health = health - beat;
        source.Play();
        healthtext.text = (health).ToString();
        Instantiate(burst, transform.position, Quaternion.identity);
        

        if (health < 0)
        {
            healthtext.text = "0";
            Destroy(gameObject);
            Instantiate(burst, transform.position, Quaternion.identity);
            lose.SetActive(true);
            pause.SetActive(false);
        }



    }


    public void getcoin(int point)
    {
        coins = coins + point;
        Instantiate(coinsplash, transform.position, Quaternion.identity);
    }









   /*  public void pointerdownleft()
     {
         leftmove = true;
     }


     public void pointerupleft()
     {
         leftmove = false;
     }

     public void pointerdownright()
     {
         rightmove = true;
     }


     public void pointerupright()
     {
         rightmove = false;
     }

     public void movement()
     {
         if (leftmove)
         {
             input = -vegam;
         }

         else if (rightmove)
         {
             input = vegam;
         }
         else
         {
             input = 0;
         }
     } */
}





