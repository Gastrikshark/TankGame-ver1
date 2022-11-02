using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class Sceneloader : MonoBehaviour
{
    public void PVP()
    {
        SceneManager.LoadScene(1);
    }

    public void SuddenDeath()
    {
        SceneManager.LoadScene(2);
    }
    
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}