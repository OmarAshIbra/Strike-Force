using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class disableStore : MonoBehaviour
{
    public void disaableTheStore()
    {
        if ((SceneManager.sceneCount > 1))
        {
            SceneManager.UnloadSceneAsync(2);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }
        else
        {
            SceneManager.LoadScene(1);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;

        }

    }
}
