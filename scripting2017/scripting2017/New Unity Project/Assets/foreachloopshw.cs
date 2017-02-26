using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foreachloopshw : MonoBehaviour {
    //for loops and for each loops run the code until the the loop becomes false;

    public List<string> gaming;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < gaming.Count; i++)
        {
            print(gaming[i]);
        }
    }
}