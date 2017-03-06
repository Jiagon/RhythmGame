using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaTileScript : MonoBehaviour {


    [SerializeField]
    int state = 0; //0 safe, 1 caution, 2 hurt
    [SerializeField]
    Material safe, danger, hurt;

    [SerializeField]
    float dangerDuration, hurtDuration;

    float dangerTimer, hurtTimer;




    // Use this for initialization
    void Start () {

        dangerTimer = dangerDuration;
        hurtTimer = hurtDuration;

	}

    // Update is called once per frame
    void Update() {

        switch (state) {
            case 0:
                GetComponentInChildren<Renderer>().material = safe;
                //Debug.Log("danger state is safe");
                break;
            case 1:
                GetComponentInChildren<Renderer>().material = danger;
                //Debug.Log("danger state is danger");

                if(dangerTimer > 0)
                {
                    dangerTimer -= Time.deltaTime;
                    //Debug.Log("Danger timer:" + dangerTimer);
                }
                else
                {
                    dangerTimer = dangerDuration;
                    state = 2; // it is now time to hurt the player if they are standing on it.
                    
                }

                break;
            case 2:
                GetComponentInChildren<Renderer>().material = hurt;
                //Debug.Log("danger state is hurt");

                if(hurtTimer > 0)
                {
                    hurtTimer -= Time.deltaTime;
                    //Debug.Log("Hurt timer:" + hurtTimer);
                }
                else
                {
                    hurtTimer = hurtDuration;
                    state = 0; // hurting time is done, reset back to the safe position.
                }



                break;
    }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (state == 2)
        {
            Debug.Log("Colliding with active space at (" + this + ")");

        }
    }
    
    public int State
    {
        get { return state; }
        set
        {
            if(value >0 && value < 3)
            state = value;
        }
    }

    public float DangerDuration
    {
        get { return dangerDuration; }
        set
        {
            dangerDuration = value;
        }
    }

    public float HurtDuration
    {
        get { return hurtDuration; }
        set
        {
            hurtDuration = value;
        }
    }
}
