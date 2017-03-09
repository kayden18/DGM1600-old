using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scopeandaccessmod : MonoBehaviour {
    //everything in a class is private to the class but the class is can be either public or private depending on where and what the class is being used

    public string owner = "Bob";
    private string custumer = "Kate";
    
    public void Awake()
    {
        string fruit = "Apple";
        if (fruit == "Apple")
        {
            print(fruit + " was sold.");
            print(custumer);
        }
        print(custumer);
        print(fruit);
        print(owner);
    }
    void Start()
    {
        string cat = "Frank";
        print(cat);
        print(owner);
    }


}
