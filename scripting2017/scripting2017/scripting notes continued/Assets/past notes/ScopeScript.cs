using UnityEngine;
using System.Collections;

public class ScopeScript : MonoBehaviour{

    //can be accessed by void Avake and void Start
    public string owner = "Bob";
    private string renter = "Kate";

    //awake is an local object and all inside it can only be seen by awake 
    //awake can access the if statement but the if statement can't access the awake
    public void Awake(){
        string cat = "Joe";
        if(cat == "Joe")
        {
            string mouse = "Helen";
            print(cat + " ate " + mouse);
            print(renter);
        }
        print(renter);
        print(cat);
        print(owner);
    }
    //start can be accessed by any class
    void Start(){
        string cat = "Frank";
        print(cat);
        print(owner);
    }
}
//void start and void awake can't see or influence eachother