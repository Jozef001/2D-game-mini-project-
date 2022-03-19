using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selector : MonoBehaviour
{
    public static int selectionno;
    public GameObject boy;
    public GameObject flash;
    public GameObject spidey;
    public GameObject venom;
    public GameObject captain;
    public GameObject iron;

    private void Start()
    {
        
        selectionno = PlayerPrefs.GetInt("selectionno");
    }



    void Update()
    {
        
        if(selectionno==0)
        {
            boy.SetActive(true);
            flash.SetActive(false);
            spidey.SetActive(false);
            venom.SetActive(false);
            captain.SetActive(false);
            iron.SetActive(false);

        }

        if (selectionno == 1)
        {
            boy.SetActive(false);
            flash.SetActive(true);
            spidey.SetActive(false);
            venom.SetActive(false);
            captain.SetActive(false);
            iron.SetActive(false);

        }

        if (selectionno == 2)
        {
            boy.SetActive(false);
            flash.SetActive(false);
            spidey.SetActive(true);
            venom.SetActive(false);
            captain.SetActive(false);
            iron.SetActive(false);

        }

        if (selectionno == 3)
        {
            boy.SetActive(false);
            flash.SetActive(false);
            spidey.SetActive(false);
            venom.SetActive(true);
            captain.SetActive(false);
            iron.SetActive(false);

        }
        if (selectionno == 4)
        {
            boy.SetActive(false);
            flash.SetActive(false);
            spidey.SetActive(false);
            venom.SetActive(false);
            captain.SetActive(true);
            iron.SetActive(false);

        }
        if (selectionno == 5)
        {
            boy.SetActive(false);
            flash.SetActive(false);
            spidey.SetActive(false);
            venom.SetActive(false);
            captain.SetActive(false);
            iron.SetActive(true);

        }
    }
   
}
