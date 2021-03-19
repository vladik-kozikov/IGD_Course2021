using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCounterScript : MonoBehaviour{

    public Text text;
    void Start()
    {
        Coin.OnCoinCollected
            += ScriptOnOnMoneyCollected;
        
    }

    void ScriptOnOnMoneyCollected(object sender, EventArgs e)
    {
        var rawText = "Coins: " +Coin.GetAmountOfCollectedCoins().ToString("0");
       if(text!=null) text.text =rawText;
    }

   
}