using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class storLogic : MonoBehaviour
{
    public GameObject eventSys;


    void Update()
    {
        if (SceneManager.sceneCount > 1)
        {
            eventSys.SetActive(false);
        }
        else
        {
            eventSys.SetActive(true);
        }

    }
}
