using scgFullBodyController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UBhealth : MonoBehaviour
{



    private static Button button;

    void Start()
    {
        button = GetComponent<Button>();
        



        UpdateButton();
    }

    public static void UpdateButton()
    {

        if (MoneyScript.moneyValue >= CurrentHealth.amountValue)
        {
            // Enough money to buy
            button.interactable = true;
        }
        else
        {
            // Not enough money to buy
            button.interactable = false;
        }
    }
}