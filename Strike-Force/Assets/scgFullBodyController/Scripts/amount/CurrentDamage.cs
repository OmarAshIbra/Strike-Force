using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentDamage : MonoBehaviour
{
    public static int amountValue = 120;
    Text amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        amount.text = "$ "+amountValue ;
    }

}
