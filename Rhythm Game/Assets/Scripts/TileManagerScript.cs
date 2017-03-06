using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerScript : MonoBehaviour {
    /// <summary>
    /// This class will be fore managing the patterns, I'm not sure how we're going to get the patterns for attacking
    /// but I do know that this class will take that information and make the relevant calls to the locations specified
    /// </summary>


    [SerializeField]
    GameObject[] tilesArray;
    ArenaTileScript activeTileScript;


    float tempPatternTimer = 5.0f;
    int[] tileIndexArray;
    int[] tileIndexArray1;

    // Use this for initialization
    void Start () {
        //tilesArray = new GameObject[9];
        tileIndexArray = new int []{ 0, 2, 4, 6, 8 };
        tileIndexArray1 = new int[] { 1, 3, 5, 7,};
    }
	
	// Update is called once per frame
	void Update () {

        if(tempPatternTimer >= 0)
        {
            tempPatternTimer -= Time.deltaTime;
        }
        else
        {
            ActivateTiles(tileIndexArray, 3, 1);
            //ActivateTiles(tileIndexArray1, 4, 1);
            tempPatternTimer = 5.0f;
        }
		
	}



    void ActivateTile(int index,float dangerTime,float hurtTime)
    {
        GameObject activeTile = tilesArray[index].gameObject;
        activeTileScript = activeTile.GetComponent<ArenaTileScript>();
        activeTileScript.DangerDuration = dangerTime;
        activeTileScript.HurtDuration = hurtTime;
        activeTileScript.State = 1; //Set danger state to danger;
        
    }

    void ActivateTiles(int [] tileIndices, float dangerTime, float hurtTime)
    {
        for(int i = 0; i < tileIndices.Length; i++)
        {
            ActivateTile(tileIndices[i], dangerTime, hurtTime);
        }
    }
}
