﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevelSelect : MonoBehaviour
{
    // Start is called before the first frame update

    public void BackToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    
    }
    public void PlayerWinsScreen()
    {
        SceneManager.LoadScene("GameVictory");
    
    }




}
