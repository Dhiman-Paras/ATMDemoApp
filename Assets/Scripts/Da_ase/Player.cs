using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public double amount;
   public int pin;
    public void SavePlayer()
    {
        
        DatabaseLocal.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = DatabaseLocal.LoadPlayer();
        amount = data.amount;
        pin =  data.pin;
        
        Debug.Log(amount + "   " + pin);
    }
 
}
