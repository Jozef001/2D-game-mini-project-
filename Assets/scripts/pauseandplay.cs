using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseandplay : MonoBehaviour
{

    public GameObject pausebutton;
    public static bool ispaused;

    public void pause()
    {
        pausebutton.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void play()
    {
        pausebutton.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }

   
    
    public void submain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
        ispaused = false;
    }
}
