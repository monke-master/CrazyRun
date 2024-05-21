using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class PauseManager : MonoBehaviour
{
    public Canvas menuCanvas;
    public Canvas authorCanvas;

    public void ShowAuthorCanvas()
    {
        authorCanvas.gameObject.SetActive(true);
        menuCanvas.gameObject.SetActive(false);
    }
    
    public void ShowMenuCanvas()
    {
        authorCanvas.gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("Scenes/Level1");
    }
}
