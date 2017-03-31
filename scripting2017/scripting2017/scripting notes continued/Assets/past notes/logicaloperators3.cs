using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaloperators3 : MonoBehaviour {

    public string string5;
    public string string6;

    public void OnButtonClick()
    {
        if (string5 == "StarWars" && string6 == "StarTrek")
        {
            print("Nerd Wars!");
        }
        if (string5 == "StarWarc" || string6 == "StarTrek")
        {
            print("What side are you on?");
        }
        if (string5 != "StarWar" && string6 != "StarTrek")
        {
            print("Avatar is better");
        }
    }
    }