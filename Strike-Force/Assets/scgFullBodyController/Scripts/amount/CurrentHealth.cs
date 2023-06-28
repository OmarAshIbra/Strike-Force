using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentHealth : MonoBehaviour
{
    public static int amountValue = 30;
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