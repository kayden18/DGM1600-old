using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class inputaddtolist : MonoBehaviour
{

    public List<string> myWeaponLists;
    public string[] myWeaponArray;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            myWeaponLists.Add("Lance");
        }
        if (Input.GetKey(KeyCode.B))
        {
            myWeaponLists.Add("Club");
        }
    }
}