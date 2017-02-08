using UnityEngine;
using System.Collections;

public class Elseclause : MonoBehaviour {

    public string password;
    public bool userAgreement;

	// Use this for initialization
	void Start () {

        if (password == "OU812" || userAgreement)
        {
            print("Correct");
        }
        else 

        {
            print("Incorrect");
        }
	
	}
}
//else clauses can't exsist without an if statement
//else clauses define the opposite of the if statement
//code checks every else clause whether there are 2 or 200
//don't copy and paste code
