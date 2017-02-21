using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaTileScript : MonoBehaviour {


    [SerializeField]
    int dangerState = 0; //0 safe, 1 caution, 2 hurt
    [SerializeField]
    Material safe, danger, hurt;

    [SerializeField]
    float dangerTimer, hurtTimer;


   


	// Use this for initialization
	void Start () {
       
            

	}

    // Update is called once per frame
    void Update() {

        switch (dangerState) {
            case 0:
                GetComponentInChildren<Renderer>().material = safe;
                Debug.Log("danger state is safe");
                break;
            case 1:
                GetComponentInChildren<Renderer>().material = danger;
                Debug.Log("danger state is danger");
                break;
            case 2:
                GetComponentInChildren<Renderer>().material = hurt;
                Debug.Log("danger state is hurt");
                break;
    }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (dangerState == 2)
        {
            Debug.Log("Colliding with active space at (" + this + ")");

        }
    }
}
