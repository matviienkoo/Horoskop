using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class PurhareScript : MonoBehaviour
{
    private int IntNoAds;

    public void OnPurchaseComplete(Product product)
    {
        switch (product.definition.id)
        {
            case "noads":
            {
                NoAds();
            }
            break;
        }
    }

    private void NoAds ()
    {
        IntNoAds = 1;
        PlayerPrefs.SetInt("IntNoAds", IntNoAds);
    }
}



