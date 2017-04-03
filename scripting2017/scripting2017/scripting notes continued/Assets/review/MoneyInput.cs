using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyInput : MonoBehaviour {

    public InputField money;
    public float MoneyToFloat()
    {
        return float.Parse(money.text);
    }
}
