using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class skinmanagerduplicate : MonoBehaviour
{

    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedskin = 0;
    public GameObject playerskin;
    public GameObject selectbutton;
    public static int selectionno;
    private int storecoin;
    public GameObject nextbutton;
    public GameObject backbutton;
    public Text selection;
    public Slider slideru;
    public Text message;


    public AudioSource source;



    private void Start()
    {

        selectionno = 0;
        selectbutton.SetActive(false);



    }

    public void next()
    {
        selectedskin = selectedskin + 1;
        if (selectedskin == skins.Count)
        {
            selectedskin = 0;
        }
        sr.sprite = skins[selectedskin];
        selectionno = selectionno + 1;
        source.Play();

    }

    public void back()
    {
        selectedskin = selectedskin - 1;
        if (selectedskin < 0)
        {
            selectedskin = skins.Count - 1;
        }
        sr.sprite = skins[selectedskin];
        selectionno = selectionno - 1;
        source.Play();

    }



    public void playgame()
    {/*
#if UNITY_EDITOR
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/prefabs/parts/head.prefab");
#endif*/
        SceneManager.LoadScene("menu");



    }



    private void Update()
    {
        PlayerPrefs.SetInt("selectionno", selectionno);
        storecoin = coin.globalpt;
        slideru.value = storecoin;


        selection.text = selectionno.ToString();

        if (selectionno == 0)
        {
            backbutton.SetActive(false);
        }
        else
        {
            backbutton.SetActive(true);
        }

        if (selectionno == 5)
        {
            nextbutton.SetActive(false);
        }
        else
        {
            nextbutton.SetActive(true);
        }


        if (selectionno == 0)
        {
            selectbutton.SetActive(true);
        }
        else if (storecoin >= 100 && selectionno == 1)
        {

            selectbutton.SetActive(true);
        }
        else if (storecoin >= 200 && selectionno == 2)
        {

            selectbutton.SetActive(true);
        }
        else if (storecoin >= 300 && selectionno == 3)
        {

            selectbutton.SetActive(true);
        }
        else if (storecoin >= 400 && selectionno == 4)
        {

            selectbutton.SetActive(true);
        }
        else if (storecoin >= 500 && selectionno == 5)
        {

            selectbutton.SetActive(true);
        }
        else
        {
            selectbutton.SetActive(false);
        }






        if (selectionno == 1)
        {
            message.text = "Collect a total of 100 coins to unlock Flash skin";

        }
        else if (selectionno == 2)
        {
            message.text = "Collect a total of 200 coins to unlock Spidey skin";

        }
        else if (selectionno == 3)
        {
            message.text = "Collect a total of 300 coins to unlock Venom skin";

        }
        else if (selectionno == 4)
        {
            message.text = "Collect a total of 400 coins to unlock Captain skin";

        }
        else if (selectionno == 5)
        {
            message.text = "Collect a total of 500 coins to unlock Ironman skin";

        }




    }
}
