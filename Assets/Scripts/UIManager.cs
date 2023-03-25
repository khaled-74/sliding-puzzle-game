using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
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

}
