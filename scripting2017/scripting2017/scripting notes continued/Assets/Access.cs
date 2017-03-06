using UnityEngine;
using System.Collections;

public class Access : MonoBehaviour {
    public ScopeScript home;

	void Start () {
        print(home.owner);
        home.Awake();
	}
}
