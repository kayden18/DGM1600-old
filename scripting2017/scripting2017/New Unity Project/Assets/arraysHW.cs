using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraysHW : MonoBehaviour {

    //arrays hold a group of strings and ints that can be accessed by functions anywhere in the code;

    int i = 0;
    string[] names = new string[] { "Matt", "Joanne", "Robert", "Ian", "James" };

    void Start () {
        while (i < names.Length)
        {
            print(names[i]);
            i++;
        }
        print("Greetings");

    }
}
