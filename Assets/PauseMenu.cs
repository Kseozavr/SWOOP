using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public Text WOW;
    public Airplane POP;
    [SerializeField]
    private bool PauseGame;
    [SerializeField]
    private GameObject pauseGameMenu;

    void Update()
    {
        if(POP.toplivo < 0)
        {
            POP.toplivo = 0;
        }

        WOW.text = "" + POP.toplivo;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void LosdMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void RecordHolder()
    {
        SceneManager.LoadScene("BuRec");
        pauseGameMenu.SetActive(false);
    }

    public void Start()
    {
        POP = GameObject.FindObjectOfType <Airplane> ().GetComponent <Airplane> ();
    }
}
