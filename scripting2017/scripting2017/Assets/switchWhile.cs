using UnityEngine;
using System.Collections;


public class switchWhile : MonoBehaviour {

    // switch statements run through the code once searching for specific variables that are string types unless used with an enum.
    public enum powerUps {FLIGHT, STREGTH, SPEED};
    public powerUps playerPowerUp;
    void Start () {
        switch (playerPowerUp){
        case powerUps.FLIGHT:
                print("player can fly");
        break;
        case powerUps.STREGTH:
                print("player can lift heavy objects");
        break;
        case powerUps.SPEED:
            print("play can move quicker");
           break;
        }
		
	}
}
