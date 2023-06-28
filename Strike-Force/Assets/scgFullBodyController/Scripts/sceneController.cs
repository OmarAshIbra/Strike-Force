using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace scgFullBodyController
{
    public class sceneController : MonoBehaviour
    {


        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {

                SceneManager.LoadScene(1);

            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                Scene scene = SceneManager.GetSceneByBuildIndex(2);
                if (SceneManager.sceneCount < 2)
                {
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                    {
                        SceneManager.LoadScene(2, LoadSceneMode.Additive);
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;
                        Time.timeScale = 0;

                    }
                }
                else
                {



                    if (scene.isLoaded)
                    {

                        SceneManager.UnloadSceneAsync(2);
                        Cursor.lockState = CursorLockMode.Locked;
                        Time.timeScale = 1;
                    }

                }

            }





            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (SceneManager.sceneCount < 2)
                {
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                    {
                        SceneManager.LoadScene(4, LoadSceneMode.Additive);
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;
                        Time.timeScale = 0;
                    }
                }
                else
                {

                    Scene scene = SceneManager.GetSceneByBuildIndex(4);

                    if (scene.isLoaded)
                    {
                        SceneManager.UnloadSceneAsync(4);
                        Cursor.lockState = CursorLockMode.Locked;
                        Time.timeScale = 1;
                    }
                    else
                    {
                        SceneManager.UnloadSceneAsync(2);
                        Cursor.lockState = CursorLockMode.Locked;
                        Time.timeScale = 1;
                    }


                }


            }
        }


    }
}