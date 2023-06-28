using scgFullBodyController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoBuy : MonoBehaviour
{



    public void OnButtonClick2()
    {
        if (MoneyScript.moneyValue >= CurrentAmmo.amountValue)
        {
            // Subtract the cost from the money and add 20 to the value in MoneyManager
            MoneyScript.moneyValue -= CurrentAmmo.amountValue;
            GunController.totalBullets += 10;
            CurrentAmmo.amountValue += 30;

           UBammo. UpdateButton();
        }
    }
}


    