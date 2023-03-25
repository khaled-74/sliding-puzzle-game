using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    int level;
    public void NextLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame() 
    {
        Application.Quit();
    }
    public void Back() 
    {
       SceneManager.LoadScene(0);
    }
    public void levelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }
}
