using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyScript : MonoBehaviour
{

    public static int moneyValue=10000000  ;
    TextMeshProUGUI money;
    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        money.text = "$ " + moneyValue;
    }

}