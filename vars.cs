using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour
{
    //data types
    public string myString = "10";
    public string myOtherString = "1";
    public int myInt = 1;
    public float myfloat = 1.2f;
    public bool myBool = false;

    void Start()
    {
        print("Hello");
    }
    void Update()
    {

    }
}

//string's identifier starts with a lower case and camelcasing the rest
//numbers must be in "" to for a string
// string identifiers can't start with a number
//strings require ""