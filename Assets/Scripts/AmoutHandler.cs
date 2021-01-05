using UnityEngine;
using UnityEngine.UI;
public class AmoutHandler : MonoBehaviour
{
    public Player player;

    public double tempAmount;
    public double tempaddAmount;
    public double a, d;
    public Text msg, recieptText;
    public InputField amountInput;
    public InputField newamountInput;


    public PageController PageController;

    public void Update()
    {
        Debug.Log(tempAmount + "   " + Load.totalamount);
    }
    public void GetAmountFromUSER(string a)
    {
        tempAmount = int.Parse(a);
    }
    public void GetAddAmountFromUSER(string a)
    {
        tempaddAmount = int.Parse(a);
    }

    public void CreditAmount() {
        a = tempaddAmount;
        Load.totalamount += tempaddAmount;
        player.amount = Load.totalamount;
        player.SavePlayer();

        PageController.GoToRecipetMenu(); // when cash is add he jump 7 menu
        recieptText.text = "RS " + a + " \nis credited in your account.\n\n Total amount is RS" + player.amount +
            "\n\n\nThank you, for using DHIMANP Bank";
        Debug.Log("add " + player.amount);
    }
    public void DebitAmount()
    {
        if (tempAmount <= Load.totalamount)
        {
            msg.text = "";
            d = tempAmount;
            Load.totalamount -= tempAmount;
            player.amount = Load.totalamount;
            player.SavePlayer();
            Debug.Log(player.amount);

            PageController.GoToRecipetMenu();
            recieptText.text = "RS " + d + " \nis debited from your account.\n\n Total amount is RS " + player.amount +
           "\n\n\nThank you, for using DHIMANP Bank";
        }
        else
        {
            msg.text = "You have only\nRS  " + Load.totalamount.ToString();

        }


    }
    public void Amount()
    {
        recieptText.text = " \n\n\n Total amount is RS " + player.amount +
          " in your account\n\n\nThank you, for using DHIMANP Bank";
    }



}
   
