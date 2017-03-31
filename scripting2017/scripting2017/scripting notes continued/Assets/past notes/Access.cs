using UnityEngine;
using System.Collections;

public class Access : MonoBehaviour {
    public ScopeScript store;

	void Start () {
        print(store.owner);
        store.Awake();
	}
}
