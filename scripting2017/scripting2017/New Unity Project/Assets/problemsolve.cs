using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class problemsolve : MonoBehaviour
{
    public List<string> animals;

    void Start()
    {
        foreach (string item in animals)
        {
            if (item == "Cat")
            {
                print(item);
            }
        }
    }
}