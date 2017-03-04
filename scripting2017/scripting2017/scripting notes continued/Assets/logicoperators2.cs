using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicoperators2 : MonoBehaviour
{

    public string string3;
    public string string4;

    public void OnButtonClick()
    {
        if (string3 == "Sonic" && string4 == "Mario")
        {
            print("Welcome player 1");
        }
        if (string3 == "Sonic" || string4 == "Mario")
        {
            print("Welcome to single player");
        }
        if (string3 != "Sonic" && string4 != "Mario")
        {
            print("Hey Luigi...");
        }
    }
}