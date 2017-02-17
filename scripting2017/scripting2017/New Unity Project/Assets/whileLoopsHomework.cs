using UnityEngine;
using System.Collections;

public class whileLoopsHomework : MonoBehaviour {

    //loops are used to read through all of the code until the function becomes false;


    int i = 0;
    public string[] example;
    public string[] exampleTwo;

    void Start()
    {
        while (i < example.Length)
        {
            print(example[i]);
            i++;
        }
        print("Done");
        while (i > exampleTwo.Length)
        {
            print(example[i]);
            i--;
        }
        print("Also done");
    }
}