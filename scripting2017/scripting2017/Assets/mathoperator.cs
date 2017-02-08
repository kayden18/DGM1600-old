using UnityEngine;
using System.Collections;

public class mathoperator : MonoBehaviour{

    public int addition = 12 + 4;
    public int subtraction = 12 - 4;
    public float division = 5.0f / 2.0f;
    public int multiplication = 10 * 2;
    public int remainder = 7 % 3;

	// Use this for initialization
	void Start () {
        addition += 9;//+= means add two
        subtraction -= 10; //-= subtract 2
        addition += 3;
        addition = 1; // = assigns
	}

}
