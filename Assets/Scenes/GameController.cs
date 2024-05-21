using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float timeInSecond = 20;
    public Text timer;
    public GameObject victoryText;
    public GameObject gameOverText;

    IEnumerator Timer()
    {
        if (timeInSecond > 0) yield return new WaitForSeconds(1);
        timeInSecond--;
        UpdateText();
        if (timeInSecond == 0)
        {
            OnGameOver();
        }
        else
        {
            StartCoroutine(Timer());
        }
       
    }
    
    void Start()
    {
        UpdateText();
        StartCoroutine(Timer());
    }
    
    void Update()
    {
        
    }

    public void OnGameOver()
    {
        gameOverText.SetActive(true);
    }

    public void OnLevelComplete()
    {
        Time.timeScale = 0f;
        victoryText.SetActive(true);
    }

    public void UpdateText()
    {
        if (timeInSecond > 9)
        {
            timer.text = "0:" + timeInSecond;
        }
        else
        {
            timer.text = "0:0" + timeInSecond;
        }
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Menu");
    }
    
    public void NextLevel()
    {
        Time.timeScale = 1f;
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene("Scenes/Level1");
        }
        else
        {
            SceneManager.LoadScene("Scenes/Level2");
        }
    }

    public void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
