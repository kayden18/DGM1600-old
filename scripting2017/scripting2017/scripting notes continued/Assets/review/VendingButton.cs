using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VendingButton : MonoBehaviour {

    public Text buttonLable;

    void Start()
    {
        buttonLable.text = productName + " $" + productPrice;
        //transform.parent.name = productName + " $" + productPrice; <- customise buttons
    }

    public MoneyInput moneyInput;

    public string productName = "Coke";
    public float productPrice = 1.5f;

	float vendProduct(float money)
    {
        float change = 0;
        if(money >= productPrice)
        {
            print("Vending " + productName + ".");
            change = money - productPrice;
        }

        return change;
    }

    public void buttonClick()
    {
        print("$" + vendProduct(moneyInput.MoneyToFloat()) + " is your change");
    }
}
