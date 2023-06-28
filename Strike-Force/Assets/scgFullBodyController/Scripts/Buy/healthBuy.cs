using scgFullBodyController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBuy : MonoBehaviour
{
    
    

   

    public void OnButtonClick2()
    {
        if (MoneyScript.moneyValue >= CurrentHealth.amountValue)
        {
            // Subtract the cost from the money and add 20 to the value in MoneyManager
            MoneyScript.moneyValue -= CurrentHealth.amountValue;
            userhealth.healthValue += 20;
            CurrentHealth.amountValue += 30;

            UBhealth.UpdateButton();
        }
    }
}