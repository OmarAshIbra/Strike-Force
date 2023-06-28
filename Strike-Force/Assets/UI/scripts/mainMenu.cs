using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    GameObject temp;
    public int sceneIndex;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndex);
        if (sceneIndex == 1)
            Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Debug.Log("Game is exiting");
        Application.Quit();
    }
    public void DisablePanel1()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        temp = panel1;
        panel1 = panel2;
        panel2 = temp;
    }
}
