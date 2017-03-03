using UnityEngine;
using System.Collections;

public class logicalOperators : MonoBehaviour {

    public string string1;
    public string string2;
	
	public void OnButtonClick () {
        if (string1 == "thing 1" && string2 == "Thing 2")
        {
            print("Things are quite tame.");
        }
        if(string1 == "Thing 1" || string2 == "Thing 2")
        {
            print("It's fun to have fun if you know what to do");
        }
        if(string1 != "Thing 1" && string2 != "Thing 2")
        {
            print("Oh what a shame");
        }
	}
	
}
