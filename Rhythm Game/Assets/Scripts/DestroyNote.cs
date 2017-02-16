﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNote : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Note")
        {
            Destroy(col.gameObject);
            Debug.Log("Gameobject destroyed.");
        }
    }
}
