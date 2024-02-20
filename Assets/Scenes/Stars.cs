using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stars : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame() 
    {
        Debug.Log("Игра закрыта.");
        Application.Quit();
    }
}
