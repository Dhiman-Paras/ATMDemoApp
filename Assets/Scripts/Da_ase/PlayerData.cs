using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {
    public double amount;
    public int pin ;
    public PlayerData(Player player )
    {
        amount = player.amount;
        pin = player.pin;

    }
}
