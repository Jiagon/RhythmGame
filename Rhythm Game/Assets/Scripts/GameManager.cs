using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private int randTime = 0;
    private float deltaTime = 0;
    private int randKey = 0;
    private ArrayList aNotes;
    private ArrayList sNotes;
    private ArrayList dNotes;
    private GameObject toInstantiate, instantiatePosition;

    public GameObject aSpawn, sSpawn, dSpawn;
    public GameObject aNote, sNote, dNote;

	// Use this for initialization
	void Start () {
        randTime = (int)Mathf.Round(Random.value * 3);

        aNotes = new ArrayList();
        sNotes = new ArrayList();
        dNotes = new ArrayList();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("A has been pressed.");
        }
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("S has been pressed.");
        }
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("D has been pressed.");
        }

        deltaTime += Time.deltaTime;

		if(deltaTime > randTime)
        {
            randKey = (int)Mathf.Round(Random.value * 3);

            if (randKey == 1)
            {
                toInstantiate = aNote;
                instantiatePosition = aSpawn;
            }
            else if(randKey == 2)
            {
                toInstantiate = sNote;
                instantiatePosition = sSpawn;
            }
            else
            {
                toInstantiate = dNote;
                instantiatePosition = dSpawn;
            }

            Instantiate(toInstantiate, instantiatePosition.transform.position, Quaternion.identity);
            Debug.Log("Created Gameobject " + toInstantiate.gameObject.name);

            randTime = (int)Mathf.Round(Random.value * 3);
            deltaTime = 0;
        }

	}
}
