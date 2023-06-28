using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    public static int amountValue = 50;
    TextMeshProUGUI amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        amount.text = "$ " + amountValue;
    }

}