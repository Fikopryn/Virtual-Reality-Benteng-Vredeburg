﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour{ 
     
    public void ChangeScene(string SampleScene)
    {

        SceneManager.LoadScene(SampleScene);

 
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
