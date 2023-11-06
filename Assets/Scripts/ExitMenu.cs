using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{ 
     
    public void ChangeScene(string MainMenu)
    {

        SceneManager.LoadScene(MainMenu);

 
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
