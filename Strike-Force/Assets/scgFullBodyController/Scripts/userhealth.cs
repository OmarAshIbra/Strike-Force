using scgFullBodyController;
using UnityEngine;


public class userhealth : MonoBehaviour
{

    public static float healthValue =100;
    GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindGameObjectWithTag("hud");
        ui.GetComponent<hudController>().uiHealth.text = healthValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        UpdateHealthText();
    }
    private void UpdateHealthText()
    {
        Debug.Log("Health Value: " + healthValue);

        ui.GetComponent<hudController>().uiHealth.text = healthValue.ToString();
    }

}