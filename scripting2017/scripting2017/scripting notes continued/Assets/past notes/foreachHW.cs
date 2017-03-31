using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class foreachHW : MonoBehaviour
{
    public List<GameObject> superPowerList;
    public List<GameObject> strengthList;
    public List<GameObject> speedList;
    public List<GameObject> flightList;


    public void CheckDate()
    {
        foreach (GameObject item in superPowerList)
        {

            switch (item.name)
            {
                case "stregth":
                    strengthList.Add(item);
                    break;
                case "Sphere":
                    speedList.Add(item);
                    break;
                case "Capsule":
                    flightList.Add(item);
                    break;
            }
        }
    }
}