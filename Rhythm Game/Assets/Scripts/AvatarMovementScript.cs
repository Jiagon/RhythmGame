using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMovementScript : MonoBehaviour {




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown("up"))
        {
            //Debug.Log("Up Pressed");
            if (transform.localPosition.y < 1)
            {
                transform.Translate(0, 1, 0);
            }
        }

        if (Input.GetKeyDown("right"))
        {
            //Debug.Log("Right Pressed");
            if(transform.localPosition.x< 1)
            {
                transform.Translate(1, 0, 0);
            }
        }

        if (Input.GetKeyDown("down"))
        {
            //Debug.Log("Down Pressed");
            if(transform.localPosition.y > -1)
            {
                transform.Translate(0, -1, 0);
            }
        }

        if (Input.GetKeyDown("left"))
        {
            //Debug.Log("Left Pressed");
            if(transform.localPosition.x > -1)
            {
                transform.Translate(-1, 0, 0);
            }
        }
    }
}
