using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageController : MonoBehaviour
{
    public GameObject homePage, allMenuPage, enterPINPage, transactionPage, accountTypePage,
         amountPage, RecepitPage,
        
        changePinPage,creditAmountPage;
   
    public PinHandler pinHandler;
    public AmoutHandler amoutHandler;
    public Text msg;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToHome(){

        msg.text = "";
        int.Parse( pinHandler.pinInput.text = "0");
        int.Parse(pinHandler.newpinInput.text = "0");
       int.Parse(amoutHandler.amountInput.text = "0");
       int.Parse(amoutHandler.newamountInput.text = "0");

        homePage.SetActive(true);
        allMenuPage.SetActive(false);
        enterPINPage.SetActive(false);
        transactionPage.SetActive(false);
        accountTypePage.SetActive(false);
        amountPage.SetActive(false); 
        RecepitPage.SetActive(false);
        changePinPage.SetActive(false);
        creditAmountPage.SetActive(false);
       
    }
    public void GoToAllMenu()
    {
        homePage.SetActive(false);
        allMenuPage.SetActive(true);
        enterPINPage.SetActive(false);
        transactionPage.SetActive(false);
        accountTypePage.SetActive(false);
        amountPage.SetActive(false);
        RecepitPage.SetActive(false);
    }
    public void GoToPINMenu()
    {
        msg.text = "";

        homePage.SetActive(false);
        allMenuPage.SetActive(false);
        enterPINPage.SetActive(true);
        transactionPage.SetActive(false);
        accountTypePage.SetActive(false);
        amountPage.SetActive(false);
        RecepitPage.SetActive(false);
    }

    public void GoToTranscationMenu()
    {
        if (Load.pin == PinHandler.tempPin)
        {
           
            homePage.SetActive(false);
            allMenuPage.SetActive(false);
            enterPINPage.SetActive(false);
            transactionPage.SetActive(true);
            accountTypePage.SetActive(false);
            amountPage.SetActive(false);
            RecepitPage.SetActive(false);
            int.Parse(pinHandler.pinInput.text = "0");
        }

    }

    public void GoToAccountTypeMenu()
    {
        homePage.SetActive(false);
        allMenuPage.SetActive(false);
        enterPINPage.SetActive(false);
        transactionPage.SetActive(false);
        accountTypePage.SetActive(true);
        amountPage.SetActive(false);
        RecepitPage.SetActive(false);
    }
    public void GoToAmountMenu()
    {
        
            homePage.SetActive(false);
            allMenuPage.SetActive(false);
            enterPINPage.SetActive(false);
            transactionPage.SetActive(false);
            accountTypePage.SetActive(false);
            amountPage.SetActive(true);
            RecepitPage.SetActive(false);
        
    }

    public void GoToChangePinPage()
    {
        
            homePage.SetActive(false);
            allMenuPage.SetActive(false);
            enterPINPage.SetActive(false);
            transactionPage.SetActive(false);
            accountTypePage.SetActive(false);
            amountPage.SetActive(false);
            RecepitPage.SetActive(false);
            changePinPage.SetActive(true);
            creditAmountPage.SetActive(false);
        
    }
    public void GoToCreditAmountPage()
    {

        homePage.SetActive(false);
        allMenuPage.SetActive(false);
        enterPINPage.SetActive(false);
        transactionPage.SetActive(false);
        accountTypePage.SetActive(false);
        amountPage.SetActive(false);
        RecepitPage.SetActive(false);
        changePinPage.SetActive(false);
        creditAmountPage.SetActive(true);

    }
    public void GoToRecipetMenu()
    {
        int.Parse(amoutHandler.amountInput.text = "0");
        int.Parse(amoutHandler.newamountInput.text = "0");

        homePage.SetActive(false);
        allMenuPage.SetActive(false);
        enterPINPage.SetActive(false);
        transactionPage.SetActive(false);
        accountTypePage.SetActive(false);
        amountPage.SetActive(false);
        RecepitPage.SetActive(true);
         creditAmountPage.SetActive(false);
        changePinPage.SetActive(false);

    }
    public void ErrorMSG() { msg.text = "Sorry\nthis type of service is not available...."; }
}
