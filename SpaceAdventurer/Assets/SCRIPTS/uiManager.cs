using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

      public void Restart()
    {
        SceneManager.LoadScene("Core Game");

    }

    public void Menu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
