using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MMScript : MonoBehaviour
{
    public GameObject pauseUI;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void GameStart()
    {
        Time.timeScale = 1f;
        AudioManager.Instance.PlayMusic("Theme");
    }

    public void toMapGame()
    {
        SceneManager.LoadScene("MainLevel");
        AudioManager.Instance.PlaySFX("Klik");
    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        AudioManager.Instance.PlaySFX("Klik");
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        GameStart();
        SceneManager.LoadScene(sceneName);
        AudioManager.Instance.PlaySFX("Klik");
    }

    public void ButtonMenu()
    {
        AudioManager.Instance.PlaySFX("Klik");
    }

    public void ExitGame()
    {
        AudioManager.Instance.PlaySFX("Klik");
        Application.Quit();
        Debug.Log("Quit");
    }

    public void BackMenu()
    {
        AudioManager.Instance.PlaySFX("Klik");
        SceneManager.LoadScene("MainMenu");
    }
    
    public void RetryGame()
    {
        AudioManager.Instance.PlaySFX("Klik");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void toShop()
    {
        AudioManager.Instance.PlaySFX("Klik");
        SceneManager.LoadScene("Shop");
    }
}