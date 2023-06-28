using UnityEngine;
using UnityEngine.SceneManagement;

public class closeUpgradeScene : MonoBehaviour
{
    // Start is called before the first frame update


    public void UnloadScene()
    {
        SceneManager.UnloadSceneAsync(2);
    }
}
