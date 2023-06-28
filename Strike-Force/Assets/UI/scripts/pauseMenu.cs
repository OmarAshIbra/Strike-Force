using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    private GameObject temp;
    public void Resume()
    {
        SceneManager.UnloadSceneAsync(4);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;

    }

    public void BackToMainMenue()
    {
        SceneManager.LoadScene(0);
    }

    public void options()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        temp = panel1;
        panel1 = panel2;
        panel2 = temp;
    }
}
