using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class foreachloops : MonoBehaviour {

    public List<GameObject> powerUpList;
    public List<GameObject> cubeList;
    public List<GameObject> sphereList;
    public List<GameObject> capsuleList;

	public void CheckDate() {
        foreach (GameObject item in powerUpList)
        {
            switch (item.name)
            {
                case "Cube":
                    cubeList.Add(item);
                    break;
                case "Sphere":
                    sphereList.Add(item);
                    break;
                case "Capsule":
                    capsuleList.Add(item);
                    break;
            }
        }
	}
}
