using UnityEngine;
using System.Collections;

public class keyInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            print("I hit A.");
        }
        else
        {
            print("no input");
        }
	}
}
