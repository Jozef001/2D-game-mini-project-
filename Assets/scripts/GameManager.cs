using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{
    public AudioSource source;
    


    public void selectchar()
    {
        SceneManager.LoadScene("playerselection");
        source.Play();
        
    }

    public void newgame()
    {
        PlayerPrefs.DeleteKey("coinstorage");
        SceneManager.LoadScene("playerselection");
        source.Play();
    }

    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("exit");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void popsound()
    {
        source.Play();
    }

    public void startgame()
    {
        SceneManager.LoadScene("game");
        source.Play();
    }
   
   






}
