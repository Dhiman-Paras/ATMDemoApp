using UnityEngine;
using UnityEngine.UI;

public class PinHandler : MonoBehaviour
{
    public Player player;
   public static int tempPin;
    int newPin;
    public  Text msg,pintext;


    public InputField pinInput;

    
    public InputField newpinInput;


    private void Start()
    {
      
    }

    private void Update()
    {
         player.LoadPlayer();
        Load.pin=player.pin;
        pintext.text = Load.pin.ToString();

    }

    public void GetPinFromUser(string p)
    {
        tempPin=int.Parse(p);
        
    }

    public void GetNewPinFromUser(string p)
    {
        newPin = int.Parse(p);
    }


    public void ChangePIN() {

        if (newPin >= 1000 && newPin <= 9999)
        {
            Load.pin = newPin;
            player.pin = Load.pin;
            player.SavePlayer();
            msg.text = "Pin Changed...";
 

        }

       
        
    }
   public void ClearMsg()
    {
        msg.text = "";
    }
    
}
