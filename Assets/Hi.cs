using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.Label(new Rect(1, 1, 30, 20), "hello");
    }
}
