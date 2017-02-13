using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {

    public string[] animals;
    public string animal = "Wolf";

	void Start () {
        foreach (string animalInAnimals in animals)
        {
            if (animal == animalInAnimals)
            {
                print("I have a match, it is a " + animalInAnimals);
            }
            else
            {
                print(animalInAnimals + " is not a match.");
            }
        }
	}
}
